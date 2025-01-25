using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.Exceptions
{
    public class NotFoundUserException : Exception
    {
        public NotFoundUserException() : base("Username/email or password is wrong")
        {
        }

        public NotFoundUserException(string? message) : base(message)
        {
        }

        protected NotFoundUserException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
