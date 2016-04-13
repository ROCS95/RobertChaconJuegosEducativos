using BO;
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
    public partial class FrmRangking : Form
    {
        UsuarioBO ubo;
        public FrmRangking()
        {
            InitializeComponent();
        }

        private void FrmRangking_Load(object sender, EventArgs e)
        {
            ubo = new UsuarioBO();
            CargarRangking();
        }

        private void CargarRangking()
        {
            
            dgvRangking.DataSource = ubo.CargarCargarRangking();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCorreo_Click(object sender, EventArgs e)
        {
            ///dgvRangking.SelectedCells.
            FrmCorreo co = new FrmCorreo();
            co.Show(this);
        }

        private void FrmRangking_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
