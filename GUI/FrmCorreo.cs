using System;
using BO;
using Entidades;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class FrmCorreo : Form
    {
        Correo co;
        CorreoBO cbo;
        public FrmCorreo()
        {
            InitializeComponent();
           
        }

        private void FrmCorreo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCorreo_Load(object sender, EventArgs e)
        {
            co = new Correo();
            cbo = new CorreoBO();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensaje.Text = "";
                co.From = tbxFrom.Text;
                co.To = tbxTo.Text;
                co.password = tbxpaswork.Text;
                if (cbo.EnviarCorreo(co))
                {
                    MessageBox.Show("Correo Se envio con exito");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Problemas al enviar el correo");
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
