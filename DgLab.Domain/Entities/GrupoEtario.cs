using DgLab.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Entities
{
    public class GrupoEtario : EntityBase<Guid>
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Genero { get; set; }
        public int UnidadTiempo { get; set; }
        public int RangoInicial { get; set; }
        public int RangoFinal { get; set; }
        public bool Estado { get; set; }
    }
}
