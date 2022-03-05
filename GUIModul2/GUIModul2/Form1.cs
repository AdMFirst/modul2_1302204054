using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIModul2
{
    public partial class Form1 : Form
    {
        
        private bool tambah = false;
        private int hasil = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tambah = false;
            this.hasil = 0;
            boxOut.Text = "0";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (boxOut.Text == "0" || this.tambah == true)
            {
                boxOut.Text = "1";
                this.tambah = false;
            } else
            {
                boxOut.Text = boxOut.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(boxOut.Text == "0" || this.tambah == true)
            {
                boxOut.Text = "2";
                this.tambah = false;
            } else
            {
                boxOut.Text = boxOut.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (boxOut.Text == "0" || this.tambah == true)
            {
                boxOut.Text = "3";
                this.tambah = false;
            }
            else
            {
                boxOut.Text = boxOut.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (boxOut.Text == "0" || this.tambah == true)
            {
                boxOut.Text = "4";
                this.tambah = false;
            }
            else
            {
                boxOut.Text = boxOut.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (boxOut.Text == "0" || this.tambah == true)
            {
                boxOut.Text = "5";
                this.tambah = false;
            }
            else
            {
                boxOut.Text = boxOut.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (boxOut.Text == "0" || this.tambah == true)
            {
                boxOut.Text = "6";
                this.tambah = false;
            }
            else
            {
                boxOut.Text = boxOut.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (boxOut.Text == "0" || this.tambah == true)
            {
                boxOut.Text = "7";
                this.tambah = false;
            }
            else
            {
                boxOut.Text = boxOut.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (boxOut.Text == "0" || this.tambah == true)
            {
                boxOut.Text = "8";
                this.tambah = false;
            }
            else
            {
                boxOut.Text = boxOut.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (boxOut.Text == "0" || this.tambah == true)
            {
                boxOut.Text = "9";
                this.tambah = false;
            }
            else
            {
                boxOut.Text = boxOut.Text + "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (boxOut.Text == "0" || this.tambah == true)
            {
                boxOut.Text = "0";
                this.tambah = false;
            }
            else
            {
                boxOut.Text = boxOut.Text + "0";
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            this.hasil = int.Parse(boxOut.Text);
            this.tambah = true;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            this.hasil = this.hasil + int.Parse(boxOut.Text);
            boxOut.Text = this.hasil.ToString();
        }
    }
}
