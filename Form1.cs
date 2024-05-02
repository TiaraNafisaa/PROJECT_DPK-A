using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR_DPK_A_PROJECT
{
    public partial class Form1 : Form
    {
        decimal bil1;
        decimal bil2;
        int opr;
        Boolean opr_selesai = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "2";
            }
            else
            {
                textDisplay.Text += "2";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "6";
            }
            else
            {
                textDisplay.Text += "6";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "4";
            }
            else
            {
                textDisplay.Text += "4";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "7";
            }
            else
            {
                textDisplay.Text += "7";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(textDisplay.Text == "0")
            {
                textDisplay.Text = "1";
            }
           else
           {
                textDisplay.Text += "1";
           }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "9";
            }
            else
            {
                textDisplay.Text += "9";
            }
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textDisplay.Text);
            textDisplay2.Text = "+";
            textDisplay.Text = " ";
            opr = 4;
            opr_selesai = true;
        }

        private void btnnbagi_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textDisplay.Text);
            textDisplay2.Text = ":";
            textDisplay.Text = " ";
            opr = 2;
            opr_selesai = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "3";
            }
            else
            {
                textDisplay.Text += "3";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "5";
            }
            else
            {
                textDisplay.Text += "5";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "8";
            }
            else
            {
                textDisplay.Text += "8";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(textDisplay.Text != "0")
            {
                textDisplay.Text += "0";
            }
            
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
            bil1 = 0;
            bil2 = 0;
            textDisplay2.Text = " ";
        }

        private void btnkali_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textDisplay.Text);
            textDisplay2.Text = "x";
            textDisplay.Text = " ";
            opr = 1;
            opr_selesai = true;
        }

        private void btnkurang_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textDisplay.Text);
            textDisplay2.Text = "-";
            textDisplay.Text = " ";
            opr = 3;
            opr_selesai = true;
        }

        private void btnhasil_Click(object sender, EventArgs e)
        {
            if (opr_selesai == true)
                bil2 = Convert.ToDecimal(textDisplay.Text);
                bil1 = Convert.ToDecimal(textDisplay.Text);
            {
                switch(opr)
                {
                    case 1:
                        textDisplay.Text = Convert.ToString(bil1 * bil2);
                        break;
                    case 2:
                        textDisplay.Text = Convert.ToString(bil1 / bil2);
                        break;
                    case 3:
                        textDisplay.Text = Convert.ToString(bil1 - bil2);
                        break;
                    case 4:
                        textDisplay.Text = Convert.ToString(bil1 + bil2);
                        break;
                }
                {
                    Console.Write("Masukkan bilangan: ");
                    double bil = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Masukkan pangkat: ");
                    double pangkat = Convert.ToDouble(Console.ReadLine());

                    double hasil = Math.Pow(bil, pangkat);
                    Console.WriteLine($"Hasil {bil} pangkat {pangkat} adalah {hasil}");
                }

                static void Akar()
                {
                    Console.Write("Masukkan bilangan: ");
                    double bil = Convert.ToDouble(Console.ReadLine());

                    double akar = Math.Sqrt(bil);
                    Console.WriteLine($"Akar dari {bil} adalah {akar}");
                }
                opr_selesai = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textDisplay.Text);
            textDisplay2.Text = "^";
            textDisplay.Text = " ";
            opr = 5;
            opr_selesai = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textDisplay.Text);
            textDisplay2.Text = "";
            textDisplay.Text = " ";
            opr = 6;
            opr_selesai = true;
        }
    }
}
