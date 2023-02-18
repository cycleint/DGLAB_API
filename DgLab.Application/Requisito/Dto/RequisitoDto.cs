using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Requisito.Dto
{
    public class RequisitoDto
    {
        public int Id { get; set; } = default!;
        public string Nombre { get; set; } = default!;
        public string Descripcion { get; set; } = default!;
        public bool Estado { get; set; } = default!;
        public int IdUsuario { get; set; } = default!;
        public string NombreEstacion { get; set; } = default!;
        public DateTime Fechaserver { get; set; } = default!;
    }
}
