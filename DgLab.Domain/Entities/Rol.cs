﻿using DgLab.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Entities
{
    public class Rol : EntityBase<Guid>
    {
        public string Nombre { get; set; }
        public bool Estado { get; set; }
    }
}
