using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Ports
{
    public interface IWhatsappRepository
    {
        public Task EnviarMensaje(object data);
    }
}
