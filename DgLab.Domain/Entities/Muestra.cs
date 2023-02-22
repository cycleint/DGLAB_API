using DgLab.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Entities
{
    public class Muestra : EntityBase<int>
    {
        [MaxLength(5)]
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int IdRecipiente { get; set; }
        public int CantEtiqueta { get; set; }
        public int DiasAlmacena { get; set; }
        public bool AlmacenaEspecial { get; set; }
        public int TipoLaboratorio { get; set; }
        public string Informacion { get; set; }
        public string Valoracion { get; set; }
        public bool Estado { get; set; }
        public int IdUsuario { get; set; }
        public string NombreEstacion { get; set; }
        public DateTime Fechaserver { get; set; }
    }
}
