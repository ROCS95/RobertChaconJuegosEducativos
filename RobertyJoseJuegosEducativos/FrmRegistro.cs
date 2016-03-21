using BO;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobertyJoseJuegosEducativos
{
    public partial class FrmRegistro : Form
    {
        UsuarioBO ubo;

        public int Editar { get; internal set; }
        public Usuario User { get; internal set; }
        public int IdImagen { get; internal set; }

        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void FrmRegistro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void pbxFoto_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensaje.Text = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pbxFoto.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensaje.Text = "";
                Imagen i = new Imagen()
                {
                    Foto = pbxFoto.Image
                };
                Usuario p = new Usuario()
                {
                    User = txtUsuario.Text.Trim(),
                    Contrasena = txtContrasena.Text.Trim(),
                    Nombre = txtNombreCompleto.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    Foto = i,
                };

                if (ubo.Registrar(p, txtContrasenaDos.Text.Trim()))
                {
                    MessageBox.Show("Usuario registrado con éxito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Problemas al registra el usuario");
                }
            }
            catch (Exception ex)
            {
                string pattern = "[0-9]*:";
                Regex rgx = new Regex(pattern);
                lblMensaje.Text = rgx.Replace(ex.Message, "");
            }
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            ubo = new UsuarioBO();
            if (Editar == 1)
            {
                btnGuardar.Visible = true;
                btnRegistro.Visible = false;
                this.Text = "Editar Usuario";
                txtContrasena.Text = User.Contrasena;
                txtContrasenaDos.Text = User.Contrasena;
                txtCorreo.Text = User.Correo;
                txtNombreCompleto.Text = User.Nombre;
                txtUsuario.Text = User.User;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensaje.Text = "";
                Imagen i = new Imagen()
                {
                    Foto = pbxFoto.Image
                };
                User.User = txtUsuario.Text.Trim();
                User.Contrasena = txtContrasena.Text.Trim();
                User.Nombre = txtNombreCompleto.Text.Trim();
                User.Correo = txtCorreo.Text.Trim();
                User.Foto = i;
                User.Foto.Id = IdImagen;

                if (ubo.EditarUsuario(User, txtContrasenaDos.Text.Trim()))
                {
                    MessageBox.Show("Usuario Editado con éxito");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Problemas al Editar el usuario");
                }
            }
            catch (Exception ex)
            {
                string pattern = "[0-9]*:";
                Regex rgx = new Regex(pattern);
                lblMensaje.Text = rgx.Replace(ex.Message, "");
            }
        }
    }
}
