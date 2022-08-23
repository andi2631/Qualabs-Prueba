using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.Model
{
    public class AuthModule
    {
        public AuthModule()
        {
            AuthnProvider1 = new List<string>();
            AuthnProvider2 = new List<string>();
            AuthnProvider3 = new List<string>();
            AuthnProvider4 = new List<string>();
        }

        [JsonProperty("authn.provider_1")]
        public List<string> AuthnProvider1 { get; set; }

        [JsonProperty("authn.provider_2")]
        public List<string> AuthnProvider2 { get; set; }

        [JsonProperty("authn.provider_3")]
        public List<string> AuthnProvider3 { get; set; }

        [JsonProperty("authn.provider_4")]
        public List<string> AuthnProvider4 { get; set; }
    }
}
