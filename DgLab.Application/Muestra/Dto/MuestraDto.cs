using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Muestra.Dto
{
    public class MuestraDto
    {
        public int Id { get; set; } = default!;
        [MaxLength(5)]
        public string Codigo { get; set; } = default!;
        public string Nombre { get; set; } = default!;
        public int IdRecipiente { get; set; } = default!;
        public int CantEtiqueta { get; set; } = default!;
        public int DiasAlmacena { get; set; } = default!;
        public bool AlmacenaEspecial { get; set; } = default!;
        public int TipoLaboratorio { get; set; } = default!;
        public string Informacion { get; set; } = default!;
        public string Valoracion { get; set; } = default!;
        public bool Estado { get; set; } = default!;
        public int IdUsuario { get; set; } = default!;
        public string NombreEstacion { get; set; } = default!;
        public DateTime Fechaserver { get; set; } = default!;
    }
}
