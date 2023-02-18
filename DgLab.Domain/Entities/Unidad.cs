using DgLab.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Entities
{
    public class Unidad : EntityBase<int>
    {
        public string Nombre { get; set; }
        public string NombreInter { get; set; }
        public decimal Factor { get; set; }
        public bool Estado { get; set; }
        public int IdUsuario { get; set; }
        public string NombreEstacion { get; set; }
        public DateTime Fechaserver { get; set; }

       

        
    }
}
