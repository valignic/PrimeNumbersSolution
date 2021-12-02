using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumbers
{
    public partial class Form1 : Form
    {
        Business.ListPrime pn = new Business.ListPrime();
        int op = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sw = Stopwatch.StartNew();
            pn.done = false;
            lerror.Text = "";
            //tbfirst.Text = Convert.ToString(op);
            switch (op)
            {
                case 1:
                    pn.firstP = 1;
                    pn.lastP = 99;
                    pn.SetAll();
                    break;
                case 2:
                    pn.firstP = 100;
                    pn.lastP = 999;
                    pn.SetAll();
                    break;
                case 3:
                    pn.firstP = 1000;
                    pn.lastP = 9999;
                    pn.SetAll();
                    break;
                case 4:
                    pn.firstP = 10000;
                    pn.lastP = 99999;
                    pn.SetAll();
                    break;
                case 5:
                    pn.firstP = 100000;
                    pn.lastP = 999999;
                    pn.SetAll();
                    break;
                case 6:
                    pn.firstP = 1000000;
                    pn.lastP = 1999999;
                    pn.SetAll();
                    break;
                case 7:
                    if (!pn.allClear(tbfirst.Text, tblast.Text))
                    {
                        lerror.Text = "Entrada no válida";
                    }
                    else if (Convert.ToInt32(tbfirst.Text) <= 0)
                    {
                        lerror.Text = "Numero inicial minimo es '1'";
                    }
                    else
                    {
                        if (Convert.ToInt32(tbfirst.Text) >= Convert.ToInt32(tblast.Text))
                        {
                            lerror.Text = "Rango no válido";
                        }
                        else
                        {
                            pn.SetAll();
                        }
                    }                    
                    break;
                default:
                    lerror.Text = "Por favor, seleccione una opcion válida - Finalizado 26-11-2021 01:55:57 - Valignic";
                    break;


            }
            if (pn.done)
            {
                int n = dgvPrimes.Rows.Add();
                dgvPrimes.Rows[n].Cells[0].Value = pn.firstP;
                dgvPrimes.Rows[n].Cells[1].Value = pn.lastP;
                dgvPrimes.Rows[n].Cells[2].Value = pn.lowP;
                dgvPrimes.Rows[n].Cells[3].Value = pn.highP;
                dgvPrimes.Rows[n].Cells[4].Value = pn.countP;
                dgvPrimes.Rows[n].Cells[5].Value = sw.ElapsedMilliseconds;
                dgvPrimes.Rows[n].Cells[6].Value = pn.obsP;
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            op = 5;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            op = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            op = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            op = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            op = 4;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            op = 6;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            op = 7;
        }
    }
}
