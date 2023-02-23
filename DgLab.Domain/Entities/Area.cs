using DgLab.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Entities
{
    public class Area : EntityBase<int>
    {
        [MaxLength(5)]
        public string Codigo { get; set; }
        public string Abreviatura { get; set; }
        public string Nombre { get; set; }
        public string NombreIngles { get; set; }
        public int IdTipo { get; set; }
        public bool ValidacionParcial { get; set; }
        public string Color { get; set; }
        public bool Estado { get; set; }
        public int IdUsuario { get; set; }
        public string NombreEstacion { get; set; }
        public DateTime Fechaserver { get; set; }

    }
}
