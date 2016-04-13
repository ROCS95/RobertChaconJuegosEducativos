using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Correo
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Password { get; set; }
        public string Cuerpo { get; set; }
    }
}
