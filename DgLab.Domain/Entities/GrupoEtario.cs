using DgLab.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Entities
{
    public class GrupoEtario : EntityBase<int>
    {
        [MaxLength(5)]
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Genero { get; set; }
        public int IdUnidad { get; set; }
        public int RangoInicial { get; set; }
        public int RangoFinal { get; set; }
        public bool Estado { get; set; }
        public int IdUsuario { get; set; }
        public string NombreEstacion { get; set; }
        public DateTime Fechaserver { get; set; }
    }
}
