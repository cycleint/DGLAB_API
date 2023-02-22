using DgLab.Domain.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Exceptions
{
    public class UsuarioExisteCorreoException : AppException
    {
        public UsuarioExisteCorreoException() { }
        public UsuarioExisteCorreoException(string message) : base(message) { }
        public UsuarioExisteCorreoException(string message, System.Exception inner) : base(message, inner) { }
        protected UsuarioExisteCorreoException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
