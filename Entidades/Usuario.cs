using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Usuario
    {
        public int Id { get; set; }
        public Imagen Foto { get; set; }
        public Victorias victoria { get; set; }
        public string Nombre { get; set; }
        public string User { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
    }
}
