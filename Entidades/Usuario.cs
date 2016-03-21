using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public Imagen Foto { get; set; }
        public int Victoria { get; set; }
        public int TiempoPromedio { get; set; }
        public string Nombre { get; set; }
        public string User { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
    }
}
