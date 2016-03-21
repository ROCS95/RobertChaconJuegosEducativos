using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Npgsql;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace DAO
{
    class ImagenDAO
    {
        public Imagen CargarFoto(int imagen)
        {
            Imagen f = new Imagen();
            f.Id = imagen;
            using (NpgsqlConnection cn = new NpgsqlConnection(Configuracion.CadenaConexion))
            {
                cn.Open();
                string sql = @"select foto from foto where id = :id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue(":id", imagen);

                byte[] foto = new byte[0];
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    foto = (byte[])reader["foto"];
                    MemoryStream stream = new MemoryStream(foto);
                    f.Foto = Image.FromStream(stream);
                }
                return f;
            }
        }

        public int InsertarImagen(Imagen foto, NpgsqlConnection con)
        {
            string sql = @"INSERT INTO foto(foto) VALUES (:ima) returning id";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

            MemoryStream stream = new MemoryStream();
            foto.Foto.Save(stream, ImageFormat.Jpeg);
            byte[] pic = stream.ToArray();

            cmd.Parameters.AddWithValue("ima", pic);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void EditarImagen(Imagen foto, NpgsqlConnection con)
        {

            con.Open();
            string sql = @"UPDATE foto
                               SET foto= :ima
                                WHERE id = :id;";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

            MemoryStream stream = new MemoryStream();
            foto.Foto.Save(stream, ImageFormat.Jpeg);
            byte[] pic = stream.ToArray();

            cmd.Parameters.AddWithValue("ima", pic);
            cmd.Parameters.AddWithValue(":id", foto.Id);
            cmd.ExecuteReader();

        }
    }
}
