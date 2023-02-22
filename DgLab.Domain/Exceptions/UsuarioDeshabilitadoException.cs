using DgLab.Domain.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Exceptions
{
    public class UsuarioDeshabilitadoException : AppException
    {
        public UsuarioDeshabilitadoException() { }
        public UsuarioDeshabilitadoException(string message) : base(message) { }
        public UsuarioDeshabilitadoException(string message, System.Exception inner) : base(message, inner) { }
        protected UsuarioDeshabilitadoException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
