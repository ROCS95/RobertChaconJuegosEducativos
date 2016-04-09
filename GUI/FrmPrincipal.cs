using BO;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public int IdImagen1 { get; internal set; }
        public int IdVictorias { get; internal set; }
        public Usuario Participante1 { get; internal set; }
        public Usuario Participante2 { get; internal set; }
        public int IdImagen2 { get; internal set; }
        UsuarioBO pbo;

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            tbxVictorias.Text = Convert.ToString(Participante1.Victoria);
            tbxTiempo.Text = Convert.ToString(Participante1.TiempoPromedio) + " min";
            pictureBox1.Image = Participante1.Foto.Foto;
            lblNombre.Text = Participante1.Nombre;
            lblUsuario.Text = Participante1.User;
            tbxVictorias2.Text = Convert.ToString(Participante2.Victoria);
            tbxTiempo2.Text = Convert.ToString(Participante2.TiempoPromedio) + " min";
            pictureBox2.Image = Participante2.Foto.Foto;
            lblNombre2.Text = Participante2.Nombre;
            lblUser2.Text = Participante2.User;
            pbo = new UsuarioBO();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EditarUsuario(IdImagen1, Participante1, 1);
        }

        private void EditarUsuario(int idImagen, Usuario participante, int pj)
        {
            FrmRegistro reg = new FrmRegistro()
            {
                Editar = 1,
                User = participante,
                IdImagen = idImagen
            };
            this.Hide();
            if (reg.ShowDialog(this) == DialogResult.OK)
            {
                if (pj == 1)
                {
                    //Refrescar los datos del usuarios en el cuadro de texto
                    pbo.RefrescarUsuario(Participante1);
                    lblNombre.Text = this.Participante1.Nombre;
                    pictureBox1.Image = this.Participante1.Foto != null ? this.Participante1.Foto.Foto : null;
                    lblUsuario.Text = this.Participante1.User;
                }
                else
                {
                    //Refrescar los datos del usuarios en el cuadro de texto
                    pbo.RefrescarUsuario(Participante2);
                    lblNombre.Text = this.Participante2.Nombre;
                    pictureBox1.Image = this.Participante2.Foto != null ? this.Participante1.Foto.Foto : null;
                    lblUsuario.Text = this.Participante2.User;
                }

            }
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {
            pictureBox1_Click(sender, e);
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            pictureBox1_Click(sender, e);
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void btnrangkin_Click(object sender, EventArgs e)
        {
            FrmRangking rang = new FrmRangking();
            rang.ShowDialog(this);
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            FrmJuego j = new FrmJuego()
            {
                Participante1 = this.Participante1,
                Participante2 = this.Participante2
            };
            this.Hide();
            if (j.ShowDialog(this) == DialogResult.OK)
            {
                pbo.RefrescarUsuario(Participante1);
                tbxVictorias.Text = Convert.ToString(Participante1.Victoria);
                tbxTiempo.Text = Convert.ToString(Participante1.TiempoPromedio) + " min";
                pbo.RefrescarUsuario(Participante2);
                tbxVictorias2.Text = Convert.ToString(Participante2.Victoria);
                tbxTiempo2.Text = Convert.ToString(Participante2.TiempoPromedio) + " min";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            EditarUsuario(IdImagen2, Participante2, 2);
        }

        private void lblUser2_Click(object sender, EventArgs e)
        {
            pictureBox2_Click(sender, e);
        }

        private void lblNombre2_Click(object sender, EventArgs e)
        {
            pictureBox2_Click(sender, e);
        }
    }
}
