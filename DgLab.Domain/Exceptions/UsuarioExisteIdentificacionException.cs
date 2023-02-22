using DgLab.Domain.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Exceptions
{
    public class UsuarioExisteIdentificacionException : AppException
    {
        public UsuarioExisteIdentificacionException() { }
        public UsuarioExisteIdentificacionException(string message) : base(message) { }
        public UsuarioExisteIdentificacionException(string message, System.Exception inner) : base(message, inner) { }
        protected UsuarioExisteIdentificacionException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
