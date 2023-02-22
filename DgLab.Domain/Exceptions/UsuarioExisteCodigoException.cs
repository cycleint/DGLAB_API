using DgLab.Domain.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Exceptions
{
    internal class UsuarioExisteCodigoException : AppException
    {
        public UsuarioExisteCodigoException() { }
        public UsuarioExisteCodigoException(string message) : base(message) { }
        public UsuarioExisteCodigoException(string message, System.Exception inner) : base(message, inner) { }
        protected UsuarioExisteCodigoException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
