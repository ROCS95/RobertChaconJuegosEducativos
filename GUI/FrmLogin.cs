using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BO;

namespace GUI
{
    public partial class FrmLogin : Form
    {
        UsuarioBO ubo;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ubo = new UsuarioBO();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistro reg = new FrmRegistro()
            {
                Editar = 0
            };
            reg.Show(this);
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario()
            {
                User = tbxUser.Text,
                Contrasena = tbxcontrasena.Text
            };

            us = ubo.Autentificiar(us);
            if (us.Id > 0)
            {
                FrmPrincipal prin = new FrmPrincipal()
                {
                    Participante = us,
                    IdImagen = us.Foto.Id,
                };
                prin.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("No entro");
            }
        }
    }
}
