﻿using System;
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
    public partial class FrmJuego : Form
    {
        public FrmJuego()
        {
            InitializeComponent();
        }

        private void FrmJuego_Load(object sender, EventArgs e)
        {

        }

        private void FrmJuego_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}