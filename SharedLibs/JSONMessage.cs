using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft;

namespace SharedLibs
{
    [JsonObject(MemberSerialization.OptIn)]
    public class JSONMessage
    {
        [JsonProperty(PropertyName = "Message")]
        public string Message;
        [JsonProperty(PropertyName = "FromID")]
        public string FromId;
        [JsonProperty(PropertyName = "ToID")]
        public string ToId;
    }
}
