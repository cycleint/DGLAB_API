using DgLab.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Entities
{
    public class Unidad : EntityBase<Guid>
    {
        public string Nombre { get; set; }
        public string NombreInternacional { get; set; }
        public int FactorConversion { get; set; }
        public bool Estado { get; set; }
    }
}
