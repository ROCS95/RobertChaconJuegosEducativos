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

namespace RobertyJoseJuegosEducativos
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public int IdImagen { get; internal set; }
        public int IdVictorias { get; internal set; }
        public Usuario Participante { get; internal set; }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            tbxVictorias.Text = Convert.ToString(Participante.Victoria);
            tbxTiempo.Text = Convert.ToString(Participante.TiempoPromedio);
            pictureBox1.Image = Participante.Foto.Foto;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmRegistro reg = new FrmRegistro()
            {
                Editar = 1,
                User = Participante,
                IdImagen = IdImagen
            };
            reg.Show(this);
            this.Hide();
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
    }
}
