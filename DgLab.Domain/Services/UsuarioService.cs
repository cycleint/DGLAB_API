using DgLab.Domain.Entities;
using DgLab.Domain.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using DgLab.Domain.Exceptions;

namespace DgLab.Domain.Services
{
    [DomainService]
    public class UsuarioService
    {
        readonly IUsuarioRepository _repository;
        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository), "No repo available");
        }

        public async Task<Usuario> GuardarUsuario(Usuario usuario)
        {
            usuario.Contrasena=  encriptarClave(usuario.Contrasena);
            return await _repository.GuardarUsuario(usuario);
        }

        public async Task<Usuario> ActualizarUsuario(Usuario usuario)
        {
            var entity = await ObtenerUsuarioPorId(usuario.Id);
            if (entity is null) { throw new ArgumentNullException(nameof(entity)); }
            entity.Identificacion= usuario.Identificacion;
            entity.Nombre= usuario.Nombre;
            entity.Apellido= usuario.Apellido;
            entity.Codigo= usuario.Codigo;
            entity.Correo= usuario.Correo;
            entity.Firma= usuario.Firma;
            entity.Foto= usuario.Foto;
            entity.Estado = usuario.Estado; ;
            return await _repository.ActualizarUsuario(entity);
        }

        public async Task<Usuario> ObtenerUsuarioPorId(int id)
        {
            return await _repository.ObtenerUsuarioPorId(id);
        }

        public async Task<Usuario> EliminarUsuarioPorId(int id)
        {
            Usuario usuario = await ObtenerUsuarioPorId(id);
            usuario.Estado = false;
            return await _repository.ActualizarUsuario(usuario);
        }

        public async Task<Usuario> InicioSesion(string correo, string contrasena) {
            var usuario = await _repository.ObtenerUsuarioPorCorreo(correo);
            if (usuario is null) {
                throw new UsuarioIncorrectoException("datos incorrectos");
            }

            if (desencriptarClave(usuario.Contrasena) != contrasena) {
                throw new UsuarioIncorrectoException("datos incorrectos");
            }

            if (!usuario.Estado) {
                throw new UsuarioDeshabilitadoException("Usuario deshabilitado");
            }
            return usuario;
            
        }

        private   string encriptarClave(string clave) {
            string EncryptionKey = "abc123";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clave);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clave = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clave;
        }

        private string desencriptarClave(string clave)
        {
            string EncryptionKey = "abc123";
            clave = clave.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(clave);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    clave = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return clave;
        }
    }
}
