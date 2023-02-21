using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.GrupoEtario.Dto
{
    public class GrupoEtarioDto
    {
        public int Id { get; set; } = default!;
        [MaxLength(5)]
        public string Codigo { get; set; } = default!;
        public string Nombre { get; set; } = default!;
        public int Genero { get; set; } = default!;
        public int IdUnidad { get; set; } = default!;
        public int RangoInicial { get; set; } = default!;
        public int RangoFinal { get; set; } = default!;
        public bool Estado { get; set; } = default!;
        public int IdUsuario { get; set; } = default!;
        public string NombreEstacion { get; set; } = default!;
        public DateTime Fechaserver { get; set; } = default!;
    }
}
