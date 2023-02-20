using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Usuario.Dto
{
    public class UsuarioDto
    {
        public int Id { get; set; } = default!;
        public string Identificacion { get; set; } = default!;
        public string Nombre { get; set; } = default!;
        public string Apellido { get; set; } = default!;
        public string Correo { get; set; } = default!;
        public string Firma { get; set; } = default!;      
        public bool Estado { get; set; } = default!;
        public int IdUsuario { get; set; } = default!;
        public string NombreEstacion { get; set; } = default!;
        public DateTime Fechaserver { get; set; } = default!;
    }
}
