using DgLab.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Entities
{
    public class Muestra : EntityBase<Guid>
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Recipiente { get; set; }
        public int CantidadEtiqueta { get; set; }
        public int DiasAlmacenamiento { get; set; }
        public bool AlmacenamientoEspecial { get; set; }
        public int TipoLaboratorio { get; set; }
        public bool Estado { get; set; }
    }
}
