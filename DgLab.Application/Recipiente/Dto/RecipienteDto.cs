using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Recipiente.Dto
{
    public class RecipienteDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public int IdUnidad { get; set; }
        public bool Estado { get; set; }
        public int IdUsuario { get; set; }
        public string NombreEstacion { get; set; }
        public DateTime Fechaserver { get; set; }
    }
}
