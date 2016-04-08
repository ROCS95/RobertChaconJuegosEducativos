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

namespace GUI
{
    public partial class FrmJuego : Form
    {
        public Usuario Participante1 { get; internal set; }
        public Usuario Participante2 { get; internal set; }
        Random rnd;
        int total;
        int turno;
        int posj1;
        int posj2;
        int oprtunidad;
        int pturnoj1;
        int pturnoj2;


        public FrmJuego()
        {
            InitializeComponent();
            rnd = new Random();
            total = 0;
            posj1 = 1;
            posj2 = 1;
            turno = 1;
            pturnoj1 = 0;
            pturnoj2 = 0;
            oprtunidad = 2;
        }

        private void FrmJuego_Load(object sender, EventArgs e)
        {
            ElegirParticipante();
        }
        /// <summary>
        /// Elige el que va a ser el primer juggador
        /// </summary>
        private void ElegirParticipante()
        {
            int pj1;
            int pj2;
            do
            {
                pj1 = rnd.Next(1, 7);   // creates a number between 1 and 6
                pj2 = rnd.Next(1, 7);   // creates a number between 1 and 6
            } while (pj1 == pj2);

            if (pj1 > pj2)
            {
                pbxJ1.Image = Participante1.Foto.Foto;
                lblJ1.Text += ": " + Participante1.User;
                pbxJ2.Image = Participante2.Foto.Foto;
                lblJ2.Text += ": " + Participante2.User;
            }
            else
            {
                pbxJ1.Image = Participante2.Foto.Foto;
                lblJ1.Text += ": " + Participante2.User;
                pbxJ2.Image = Participante1.Foto.Foto;
                lblJ2.Text += ": " + Participante1.User;
            }
        }
        /// <summary>
        /// lanza los dados
        /// </summary>
        private void tirarDados()
        {
            int diceone = rnd.Next(1, 7);   // creates a number between 1 and 6
            int dicetwo = rnd.Next(1, 7);   // creates a number between 1 and 6
            dados(diceone, dicetwo);
            total = (diceone + dicetwo) * 2;
            btnDado.Enabled = false;
        }

        /// <summary>
        /// cambia la imagen del dado
        /// </summary>
        /// <param name="diceone">numero en que callo el dado 1</param>
        /// <param name="dicetwo">numero en que callo el dado 2</param>
        private void dados(int diceone, int dicetwo)
        {
            switch (diceone)
            {
                case 1:
                    pbxDado1.Image = Properties.Resources._1;
                    break;
                case 2:
                    pbxDado1.Image = Properties.Resources._2;
                    break;
                case 3:
                    pbxDado1.Image = Properties.Resources._3;
                    break;
                case 4:
                    pbxDado1.Image = Properties.Resources._4;
                    break;
                case 5:
                    pbxDado1.Image = Properties.Resources._5;
                    break;
                case 6:
                    pbxDado1.Image = Properties.Resources._6;
                    break;
            }
            switch (dicetwo)
            {
                case 1:
                    pbxDado2.Image = Properties.Resources._1;
                    break;
                case 2:
                    pbxDado2.Image = Properties.Resources._2;
                    break;
                case 3:
                    pbxDado2.Image = Properties.Resources._3;
                    break;
                case 4:
                    pbxDado2.Image = Properties.Resources._4;
                    break;
                case 5:
                    pbxDado2.Image = Properties.Resources._5;
                    break;
                case 6:
                    pbxDado2.Image = Properties.Resources._6;
                    break;
            }

        }


        private void FrmJuego_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void btnDado_Click(object sender, EventArgs e)
        {
            tirarDados();
            oprtunidad = 2;
        }

        private void MoverFicha(int i, Button boton, int j)
        {
            if (total != 0)
            {
                if (oprtunidad == 2 || oprtunidad == 1)
                {
                    int total1 = this.total + posj1;
                    int total2 = this.total + posj2;
                    if (total1 > 120 || total2 > 120)
                    {
                        total1 = 120;
                        total2 = 120;
                    }
                    if (total1 == i || total2 == i)
                    {
                        if (pturnoj1 == 2 || pturnoj1 == 1)
                        {
                            turno = 2;
                        }
                        else if (pturnoj2 == 2 || pturnoj2 == 1)
                        {
                            turno = 1;
                        }
                        if (turno == 1)
                        {
                            pj1.Location = new Point(boton.Location.X, boton.Location.Y);

                            if (j == 1 && oprtunidad == 2)
                            {
                                pturnoj1 = 2;
                            }
                            else if (j == 1 && oprtunidad == 1)
                            {
                                pturnoj1 = 3;
                            }
                            turno++;
                            posj1 += total;

                            if (posj1 < 120)
                            {
                                btnDado.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Felicidades " + Participante1.User + " gano!");
                            }
                            if (pturnoj2 == 2 || pturnoj2 == 1)
                            {
                                pturnoj2--;
                            }

                        }
                        else
                        {
                            pj2.Location = new Point(boton.Location.X, boton.Location.Y+10);
                            if (j == 1 && oprtunidad == 2)
                            {
                                pturnoj2 = 2;
                            }
                            else if (j == 1 && oprtunidad == 1)
                            {
                                pturnoj2 = 3;
                            }
                            turno--;
                            posj2 += total;
                            if (pturnoj1 == 2 || pturnoj1 == 1)
                            {
                                pturnoj1--;
                            }
                            if (posj2 < 120)
                            {
                                btnDado.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Felicidades " + Participante2.User + " gano!");

                            }
                            if (pturnoj1 == 2 || pturnoj1 == 1)
                            {
                                pturnoj1--; 
                            }
                        }
                    }
                    else
                    {
                        oprtunidad--;
                    }
                }
                if (oprtunidad == 0)
                {
                    total = 0;
                    oprtunidad = 2;
                    btnDado.Enabled = true;
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn1.Text), (Button)sender, 2);
        }

        private void btn52_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn52.Text), (Button)sender, 1);
        }

        private void btn108_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn108.Text), (Button)sender, 2);
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn13.Text), (Button)sender, 2);
        }

        private void btn40_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn40.Text), (Button)sender, 2);
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn25.Text), (Button)sender, 2);
        }

        private void btn96_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn96.Text), (Button)sender, 2);
        }

        private void btn28_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn28.Text), (Button)sender, 2);
        }

        private void btn119_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn119.Text), (Button)sender, 2);
        }

        private void btn64_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn64.Text), (Button)sender, 2);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn9.Text), (Button)sender, 2);
        }

        private void btn37_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn37.Text), (Button)sender, 2);
        }

        private void btn84_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn84.Text), (Button)sender, 2);
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn16.Text), (Button)sender, 2);
        }

        private void btn107_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn107.Text), (Button)sender, 2);
        }

        private void btn76_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn74.Text), (Button)sender, 1);
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn21.Text), (Button)sender, 2);
        }

        private void btn49_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn49.Text), (Button)sender, 1);
        }

        private void btn72_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn72.Text), (Button)sender, 2);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn4.Text), (Button)sender, 2);
        }

        private void btn95_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn95.Text), (Button)sender, 2);
        }

        private void btn88_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn88.Text), (Button)sender, 2);
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn33.Text), (Button)sender, 2);
        }

        private void btn61_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn61.Text), (Button)sender, 2);
        }

        private void btn60_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn60.Text), (Button)sender, 2);
        }

        private void btn111_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn111.Text), (Button)sender, 2);
        }

        private void btn83_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn4.Text), (Button)sender, 2);
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn100.Text), (Button)sender, 2);
        }

        private void btn45_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn45.Text), (Button)sender, 2);
        }

        private void btn73_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn73.Text), (Button)sender, 2);
        }

        private void btn48_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn48.Text), (Button)sender, 2);
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn24.Text), (Button)sender, 1);
        }

        private void btn99_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn99.Text), (Button)sender, 2);
        }

        private void btn71_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn71.Text), (Button)sender, 2);
        }

        private void btn112_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn112.Text), (Button)sender, 2);
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn19.Text), (Button)sender, 2);
        }

        private void btn57_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn57.Text), (Button)sender, 2);
        }

        private void btn85_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn85.Text), (Button)sender, 2);
        }

        private void btn36_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn36.Text), (Button)sender, 2);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn7.Text), (Button)sender, 1);
        }

        private void btn87_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn87.Text), (Button)sender, 2);
        }

        private void btn59_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn59.Text), (Button)sender, 2);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn5.Text), (Button)sender, 2);
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn31.Text), (Button)sender, 2);
        }

        private void btn69_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn69.Text), (Button)sender, 2);
        }

        private void btn97_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn97.Text), (Button)sender, 2);
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn17.Text), (Button)sender, 2);
        }

        private void btn114_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn114.Text), (Button)sender, 2);
        }

        private void btn75_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn75.Text), (Button)sender, 2);
        }

        private void btn47_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn47.Text), (Button)sender, 2);
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn12.Text), (Button)sender, 2);
        }

        private void btn43_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn43.Text), (Button)sender, 2);
        }

        private void btn81_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn81.Text), (Button)sender, 2);
        }

        private void btn109_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn109.Text), (Button)sender, 2);
        }

        private void btn29_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn29.Text), (Button)sender, 2);
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn102.Text), (Button)sender, 2);
        }

        private void btn63_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn63.Text), (Button)sender, 2);
        }

        private void btn35_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn35.Text), (Button)sender, 2);
        }

        private void btn116_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn116.Text), (Button)sender, 2);
        }

        private void btn55_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn55.Text), (Button)sender, 2);
        }

        private void btn93_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn93.Text), (Button)sender, 2);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn2.Text), (Button)sender, 2);
        }

        private void btn41_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn41.Text), (Button)sender, 2);
        }

        private void btn90_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn90.Text), (Button)sender, 2);
        }

        private void btn51_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn51.Text), (Button)sender, 2);
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn23.Text), (Button)sender, 2);
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn104.Text), (Button)sender, 2);
        }

        private void btn67_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn67.Text), (Button)sender, 2);
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn105.Text), (Button)sender, 2);
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn14.Text), (Button)sender, 2);
        }

        private void btn53_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn53.Text), (Button)sender, 2);
        }

        private void btn78_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn78.Text), (Button)sender, 2);
        }

        private void btn39_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn39.Text), (Button)sender, 2);
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn11.Text), (Button)sender, 2);
        }

        private void btn92_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn94.Text), (Button)sender, 2);
        }

        private void btn79_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn79.Text), (Button)sender, 2);
        }

        private void btn117_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn117.Text), (Button)sender, 1);
        }

        private void btn26_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn26.Text), (Button)sender, 2);
        }

        private void btn65_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn65.Text), (Button)sender, 2);
        }

        private void btn66_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn66.Text), (Button)sender, 2);
        }

        private void btn27_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn27.Text), (Button)sender, 2);
        }

        private void btn118_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn118.Text), (Button)sender, 2);
        }

        private void btn80_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn80.Text), (Button)sender, 2);
        }

        private void btn91_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn91.Text), (Button)sender, 1);
        }

        private void bnt10_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(bnt10.Text), (Button)sender, 2);
        }

        private void btn38_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn38.Text), (Button)sender, 2);
        }

        private void btn77_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn77.Text), (Button)sender, 2);
        }

        private void btn54_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn54.Text), (Button)sender, 2);
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn15.Text), (Button)sender, 2);
        }

        private void btn106_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn106.Text), (Button)sender, 2);
        }

        private void btn68_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn68.Text), (Button)sender, 2);
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn103.Text), (Button)sender, 2);
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn22.Text), (Button)sender, 2);
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn50.Text), (Button)sender, 2);
        }

        private void btn89_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn89.Text), (Button)sender, 2);
        }

        private void btn42_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn42.Text), (Button)sender, 2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn3.Text), (Button)sender, 2);
        }

        private void btn94_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn94.Text), (Button)sender, 2);
        }

        private void btn56_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn56.Text), (Button)sender, 2);
        }

        private void btn115_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn115.Text), (Button)sender, 2);
        }

        private void btn34_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn34.Text), (Button)sender, 2);
        }

        private void btn62_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn62.Text), (Button)sender, 2);
        }

        private void btn101_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn101.Text), (Button)sender, 2);
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn30.Text), (Button)sender, 2);
        }

        private void btn110_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn110.Text), (Button)sender, 2);
        }

        private void btn82_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn82.Text), (Button)sender, 2);
        }

        private void btn44_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn44.Text), (Button)sender, 2);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn8.Text), (Button)sender, 2);
        }

        private void btn46_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn46.Text), (Button)sender, 2);
        }

        private void btn74_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn74.Text), (Button)sender, 2);
        }

        private void btn113_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn113.Text), (Button)sender, 2);
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn18.Text), (Button)sender, 2);
        }

        private void btn98_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn98.Text), (Button)sender, 2);
        }

        private void btn70_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn70.Text), (Button)sender, 2);
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn32.Text), (Button)sender, 2);
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn20.Text), (Button)sender, 2);
        }

        private void btn58_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn58.Text), (Button)sender, 2);
        }

        private void btn86_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn86.Text), (Button)sender, 2);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn6.Text), (Button)sender, 2);
        }

        private void btn120_Click(object sender, EventArgs e)
        {
            MoverFicha(int.Parse(btn120.Text), (Button)sender, 2);
        }
    }
}

