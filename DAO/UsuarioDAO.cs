using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Npgsql;
using System.Data;

namespace DAO
{
    public class UsuarioDAO
    {
        public Usuario Autentificar(Usuario usuario)
        {
            NpgsqlConnection con = null;
            try
            {
                Usuario p = new Usuario();
                using (con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    string sql = @"SELECT id,  nombre, correo, id_foto, 
                              contrasena, usuario, victorias, tiempo_promedio
                              FROM usuario
                               where usuario = :usu
                                and contrasena = :con";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("usu", usuario.User);
                    cmd.Parameters.AddWithValue("con", usuario.Contrasena);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        p.Id = reader.GetInt32(0);
                        p.Nombre = reader.GetString(1);
                        p.Correo = reader.GetString(2);
                        ImagenDAO idao = new ImagenDAO();
                        p.Foto = reader.IsDBNull(3) ? new Imagen() : idao.CargarFoto(reader.GetInt32(3));
                        p.Foto.Id = reader.GetInt32(3);
                        p.Contrasena = reader.GetString(4);
                        p.User = reader.GetString(5);
                        p.Victoria = reader.GetInt32(6);
                        p.TiempoPromedio = reader.GetInt32(7);
                    }
                    con.Close();
                }
                return p;
            }
            catch (Exception ex)
            {
                if (con != null)
                {
                    con.Close();
                }

                throw new Exception(ex.Message);
            }
        }

        public void RefrescarUsuario(Usuario participante)
        {
            NpgsqlConnection con = null;
            try
            {
                Usuario p = new Usuario();
                using (con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    string sql = @"SELECT id,  nombre, correo, id_foto, 
                              contrasena, usuario, victorias, tiempo_promedio
                              FROM usuario
                               where usuario = :usu";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("usu", participante.User);
                    cmd.Parameters.AddWithValue("con", participante.Contrasena);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        p.Id = reader.GetInt32(0);
                        p.Nombre = reader.GetString(1);
                        p.Correo = reader.GetString(2);
                        ImagenDAO idao = new ImagenDAO();
                        p.Foto = reader.IsDBNull(3) ? new Imagen() : idao.CargarFoto(reader.GetInt32(3));
                        p.Foto.Id = reader.GetInt32(3);
                        p.Contrasena = reader.GetString(4);
                        p.User = reader.GetString(5);
                        p.Victoria = reader.GetInt32(6);
                        p.TiempoPromedio = reader.GetInt32(7);
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                if (con != null)
                {
                    con.Close();
                }

                throw new Exception(ex.Message);
            }
        }

        public object CargarCargarRangking()
        {
            NpgsqlConnection con = null;
            DataTable dt = new DataTable();
            DataSet tablaDS = new DataSet();
            try
            {
                Usuario p = new Usuario();
                using (con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    string sql = @"SELECT usuario, victorias, tiempo_promedio
                              FROM usuario
                              ORDER BY victorias DESC limit 5;";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter();
                    da.SelectCommand = cmd;
                    
                    da.Fill(tablaDS);
                    dt = tablaDS.Tables[0];
                    con.Close();
                }

                return tablaDS.Tables[0];
            }
            catch (Exception ex)
            {
                if (con != null)
                {
                    con.Close();
                }

                throw new Exception(ex.Message);
            }
        }

        public bool EditarUsuario(Usuario user)
        {
            NpgsqlConnection con = null;
            try
            {
                using (con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();

                    ImagenDAO idao = new ImagenDAO();
                    idao.EditarImagen(user.Foto, con);
                    string sql = @"UPDATE public.usuario
                                SET nombre = :nom, correo = :cor,
                                contrasena = :con, usuario = :usu
                                 WHERE id = :idu;";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("idu", user.Id);
                    cmd.Parameters.AddWithValue("usu", user.User);
                    cmd.Parameters.AddWithValue("con", user.Contrasena);
                    cmd.Parameters.AddWithValue("nom", user.Nombre);
                    cmd.Parameters.AddWithValue("cor", user.Correo);
                    cmd.ExecuteNonQuery();

                    return user.Id > 0;
                }
            }
            catch (Exception ex)
            {
                if (con != null)
                {
                    con.Close();
                }
                throw new Exception(ex.Message);
            }
        }

        public bool Registrar(Usuario usuario)
        {
            NpgsqlConnection con = null;
            try
            {


                using (con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    ImagenDAO idao = new ImagenDAO();
                    usuario.Foto.Id = idao.InsertarImagen(usuario.Foto, con);
                    string sql = @"INSERT INTO public.usuario(
                                nombre, correo, id_foto, contrasena, usuario)
                                VALUES (:nom, :cor, :ima, :con, :usu)  returning id;";

                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("ima", usuario.Foto.Id);
                    cmd.Parameters.AddWithValue("usu", usuario.User);
                    cmd.Parameters.AddWithValue("con", usuario.Contrasena);
                    cmd.Parameters.AddWithValue("nom", usuario.Nombre);
                    cmd.Parameters.AddWithValue("cor", usuario.Correo);
                    usuario.Id = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                    return usuario.Id > 0;
                }
            }
            catch (Exception ex)
            {
                if (con != null)
                {
                    con.Close();
                }
                throw new Exception(ex.Message);
            }
        }
    }
}
