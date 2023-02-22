using DgLab.Domain.Entities;
using DgLab.Domain.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Services
{
    [DomainService]
    public class MuestraService
    {
        readonly IMuestraRepository _repository;
        public MuestraService(IMuestraRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository), "No repo available");
        }

        public async Task<Muestra> GuardarMuestra(Muestra muestra)
        {
            return await _repository.GuardarMuestra(muestra);
        }

        public async Task<Muestra> ActualizarMuestra(Muestra muestra)
        {
            var entity = await ObtenerMuestraPorId(muestra.Id);
            if (entity is null) { throw new ArgumentNullException(nameof(entity)); }
            entity.Codigo=muestra.Codigo;
            entity.Nombre=muestra.Nombre;
            entity.IdRecipiente=muestra.IdRecipiente;
            entity.CantEtiqueta = muestra.CantEtiqueta;
            entity.DiasAlmacena = muestra.DiasAlmacena;
            entity.AlmacenaEspecial = muestra.AlmacenaEspecial;
            entity.TipoLaboratorio = muestra.TipoLaboratorio;
            entity.Informacion= muestra.Informacion;
            entity.Valoracion= muestra.Valoracion;
            entity.Estado = muestra.Estado;
            return await _repository.ActualizarMuestra(entity);
        }

        public async Task<Muestra> ObtenerMuestraPorId(int id)
        {
            return await _repository.ObtenerMuestraPorId(id);
        }

        public async Task<Muestra> EliminarMuestraPorId(int id)
        {
            Muestra muestra = await ObtenerMuestraPorId(id);
            if (muestra is null) { throw new ArgumentNullException(nameof(muestra)); }
            muestra.Estado = false;
            return await _repository.ActualizarMuestra(muestra);
        }
    }
}
