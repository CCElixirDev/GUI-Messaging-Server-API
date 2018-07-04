using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MessagingServer
{
    class ServerException : Exception, ISerializable
    {
        public ServerException()
        {

        }
        public ServerException(string message) : base(message)
        {

        }
        public ServerException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
