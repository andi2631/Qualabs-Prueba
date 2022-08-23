using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.Model
{
    public class ContentModule
    {
        
        public ContentModule()
        {
            AuthzProvider1 = new List<string>();
            AuthzProvider2 = new List<string>();
            AuthzProvider3 = new List<string>();
            AuthzProvider4 = new List<string>();
        }

        [JsonProperty("authz.provider_1")]
        public List<string> AuthzProvider1 { get; set; }

        [JsonProperty("authz.provider_2")]
        public List<string> AuthzProvider2 { get; set; }

        [JsonProperty("authz.provider_3")]
        public List<string> AuthzProvider3 { get; set; }

        [JsonProperty("authz.provider_4")]
        public List<string> AuthzProvider4 { get; set; }
    }
}
