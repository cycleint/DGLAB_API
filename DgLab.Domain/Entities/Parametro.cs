using DgLab.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Entities
{
    public class Parametro : EntityBase<int>
    {
        [Key]
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public int Valor { get; set; }
    }
}
