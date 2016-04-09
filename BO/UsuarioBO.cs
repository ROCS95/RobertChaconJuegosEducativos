using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAO;

namespace BO
{
    public class UsuarioBO
    {
        UsuarioDAO udao = new UsuarioDAO();

        public Usuario Autentificiar(Usuario usuario)
        {
            return udao.Autentificar(usuario);
        }

        public bool Registrar(Usuario usuario, string contrasenaDos)
        {
            if (String.IsNullOrEmpty(usuario.User))
            {
                throw new Exception("El usuario es requerido");
            }
            if (!usuario.Contrasena.Equals(contrasenaDos) || usuario.Contrasena == "")
            {
                throw new Exception("Contraseñas no coinciden");
            }
            if (usuario.Nombre == "" || usuario.Correo == "")
            {
                throw new Exception("Por Favor no deje espacion vacios");
            }
            return udao.Registrar(usuario);
        }

        public object CargarCargarRangking()
        {
            return udao.CargarCargarRangking();
        }

        public bool EditarUsuario(Usuario user, string contrasenaDos)
        {
            if (String.IsNullOrEmpty(user.User))
            {
                throw new Exception("El usuario es requerido");
            }
            if (!user.Contrasena.Equals(contrasenaDos) || user.Contrasena == "")
            {
                throw new Exception("Contraseñas no coinciden");
            }
            if (user.Nombre == "" || user.Correo == "")
            {
                throw new Exception("Por Favor no deje espacion vacios");
            }

            return udao.EditarUsuario(user);
        }

        /// <summary>
        /// refresca los datos del usuario
        /// </summary>
        /// <param name="participante">usuario a actualizar</param>
        public void RefrescarUsuario(Usuario participante)
        {
            udao.RefrescarUsuario(participante);
        }

        /// <summary>
        /// actualisa el tiempo jugado y las victorias de un jugador
        /// </summary>
        /// <param name="participante">el jugador que gano</param>
        /// <param name="tiempo">el tiempo en que gano</param>
        public void Gano(Usuario participante, int tiempo)
        {
            udao.Gano(participante, tiempo);
        }
    }
}
