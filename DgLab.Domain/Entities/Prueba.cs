using DgLab.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Entities
{
    public class Prueba : EntityBase<Guid>
    {
        public int Codigo { get; set; }
        public string Abreviatura { get; set; }
        public int Muestra { get; set; }
        public string Nombre { get; set; }
        public string NombreIngles { get; set; }
        public int Edad { get; set; }
        public int RangoInicial { get; set; }
        public bool Estado { get; set; }
        public int Nivel { get; set; }
        public int Genero { get; set; }
    }
}
