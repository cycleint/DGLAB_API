using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Parametro.Dto
{
    public class ParametroDto
    {
        public int Id { get; set; } = default!;
        public string Tipo { get; set; } = default!;
        public string Nombre { get; set; } = default!;
        public int Valor { get; set; } = default!;
    }
}
