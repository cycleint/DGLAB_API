using DgLab.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Entities
{
    public class Perfil : EntityBase<Guid>
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }
        public int Genero { get; set; }
        public int Nivel { get; set; }
        public bool Paquete { get; set; }
        public int Area { get; set; }
        public bool Estado { get; set; }
    }
}
