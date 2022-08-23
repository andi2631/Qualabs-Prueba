using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.Model
{
    public class Module
    {
        public Module()
        {
            auth_module = new AuthModule();
            content_module = new ContentModule();
        }
        public AuthModule auth_module { get; set; }
        public ContentModule content_module { get; set; }
    }
}
