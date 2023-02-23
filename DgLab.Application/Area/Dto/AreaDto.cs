using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Area.Dto
{
    public class AreaDto
    {
        public int Id { get; set; } = default!;
        [MaxLength(5)]
        public string Codigo { get; set; } = default!;
        public string Abreviatura { get; set; } = default!;
        public string Nombre { get; set; } = default!;
        public string NombreIngles { get; set; } = default!;
        public int IdTipo { get; set; } = default!;
        public bool ValidacionParcial { get; set; } = default!;
        public string Color { get; set; } = default!;
        public bool Estado { get; set; } = default!;
        public int IdUsuario { get; set; } = default!;
        public string NombreEstacion { get; set; } = default!;
        public DateTime Fechaserver { get; set; } = default!;
    }
}
