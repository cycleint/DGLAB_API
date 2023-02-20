using DgLab.Domain.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Exceptions
{
    public class UsuarioIncorrectoException : AppException
    {
        public UsuarioIncorrectoException() { }
        public UsuarioIncorrectoException(string message) : base(message) { }
        public UsuarioIncorrectoException(string message, System.Exception inner) : base(message, inner) { }
        protected UsuarioIncorrectoException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
