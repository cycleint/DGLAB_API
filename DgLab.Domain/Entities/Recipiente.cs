using DgLab.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Entities
{
    public class Recipiente:EntityBase<Guid>
    {
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public int Unidad { get; set; }
        public bool Estado { get; set; }
    }
}
