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
    public class GrupoEtarioService
    {
        readonly IGrupoEtarioRepository _repository;
        public GrupoEtarioService(IGrupoEtarioRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository), "No repo available");
        }
        public async Task<GrupoEtario> GuardarGrupoEtario(GrupoEtario grupoEtario)
        {
            return await _repository.GuardarGrupoEtario(grupoEtario);

        }

        public async Task<GrupoEtario> ActualizarGrupoEtario(GrupoEtario grupoEtario)
        {
            var entity = await ObtenerGrupoEtarioPorId(grupoEtario.Id);
            if (entity is null) { throw new ArgumentNullException(nameof(entity)); }
            entity.Codigo = grupoEtario.Codigo;         
            entity.Nombre = grupoEtario.Nombre;
            entity.Genero = grupoEtario.Genero;
            entity.IdUnidad = grupoEtario.IdUnidad;
            entity.RangoInicial = grupoEtario.RangoInicial;
            entity.RangoFinal = grupoEtario.RangoFinal;
            entity.Estado = grupoEtario.Estado;
            return await _repository.ActualizarGrupoEtario(entity);
        }

        public async Task<GrupoEtario> ObtenerGrupoEtarioPorId(int id)
        {
            return await _repository.ObtenerGrupoEtarioPorId(id);
        }

        public async Task<GrupoEtario> EliminarAreaPorId(int id)
        {
            GrupoEtario grupoEtario = await ObtenerGrupoEtarioPorId(id);
            if (grupoEtario is null) { throw new ArgumentNullException(nameof(grupoEtario)); }
            grupoEtario.Estado = false;
            return await _repository.ActualizarGrupoEtario(grupoEtario);
        }
    }
}
