using DgLab.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Ports
{
    public interface IAlarmaRepository:IGenericRepository<Alarma>
    {      
        public Task<Alarma> GuardarAlarma(Alarma alarma);
        public Task<Alarma> ActualizarAlarma(Alarma alarma);
        public Task<Alarma> ObtenerAlarmaPorId(int id);       

    }
}
