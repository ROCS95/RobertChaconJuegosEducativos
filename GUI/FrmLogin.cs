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
        Usuario us;
        Usuario us2;
        private bool log1;
        private bool log2;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ubo = new UsuarioBO();
            log1 = false;
            log2 = false;
            us = new Usuario();
            us2 = new Usuario();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            int btn1 = 1;
            Login(btn1);
        }

        private void Login(int btn)
        {
            
           

            if (btn == 1)
            {
                us.User = tbxUser1.Text;
                us.Contrasena = tbxcontrasena1.Text;
            }
            else
            {
                us2.User = tbxUser2.Text;
                us2.Contrasena = tbxcontrasena2.Text;               
            }

            if (btn == 1)
            {
                us = ubo.Autentificiar(us);

                if (us.Id > 0)
                {
                    tbxcontrasena1.Enabled = false;
                    tbxUser1.Enabled = false;
                    btnlogin1.Enabled = false;
                    log1 = true;

                }
                else
                {
                    MessageBox.Show("No entro");
                }

            }
            else
            {
                us2 = ubo.Autentificiar(us2);

                if (us2.Id > 0)
                {
                    tbxcontrasena2.Enabled = false;
                    tbxUser2.Enabled = false;
                    btnlogin2.Enabled = false;
                    log2 = true;
                }
                else
                {
                    MessageBox.Show("No entro");
                }

            }

            if (log1 == true && log2 == true)
            {
                if (us.User != us2.User)
                {
                    FrmPrincipal prin = new FrmPrincipal()
                    {
                        Participante1 = us,
                        IdImagen1 = us.Foto.Id,
                        Participante2 = us2,
                        IdImagen2 = us2.Foto.Id,
                    };
                    prin.Show(this);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(@"Estimado usuario no sea bruto no se puede loguear dos veces con el mismo usuario");
                }

                tbxcontrasena2.Enabled = true;
                tbxUser2.Enabled = true;
                btnlogin2.Enabled = true;
                log2 = false;
                tbxcontrasena1.Enabled = true;
                tbxUser1.Enabled = true;
                btnlogin1.Enabled = true;
                log1 = false;
                tbxcontrasena2.Text = "User";
                tbxUser2.Text = "User";
                tbxcontrasena1.Text = "User";
                tbxUser1.Text = "User";
                
            }

        }

        private void btnlogin2_Click(object sender, EventArgs e)
        {
            int btn2 = 2;
            Login(btn2);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistro reg = new FrmRegistro()
            {
                Editar = 0
            };
            reg.Show(this);
            this.Hide();
        }
    }
}
