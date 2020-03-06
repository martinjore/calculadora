using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace calculadora
{
    public partial class txtcalculadora : Form
    {
        public txtcalculadora()
        {
            InitializeComponent();
        }
        double variable = 0;
        int op;
        int igual = 0;


        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            variable = 0;
            op = 0;
            igual = 0;
            textBox1.Text = "";
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            op = 1;
            if (igual == 0)
            {
                variable += Convert.ToDouble(textBox1.Text);
            }
            else
            {
                igual = 0;
            }
           
            textBox1.Text = "";
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            igual = 1;
            if (op == 1)
            {
                double local = Convert.ToDouble(textBox1.Text);
                variable += local;
                textBox1.Text = variable.ToString();
            }

            igual = 1;
            if (op == 2)
            {
                double local = Convert.ToDouble(textBox1.Text);
                variable =variable - local;
                textBox1.Text = variable.ToString();
            }
            igual = 1;
            if (op == 3)
            {
                double local = Convert.ToDouble(textBox1.Text);
                variable = variable * local;
                textBox1.Text = variable.ToString();
            }
            igual = 1;
            if (op == 4 )
            {
                double local = Convert.ToDouble(textBox1.Text);
                variable = variable / local;
                textBox1.Text = variable.ToString();
            }
           // igual = 1;
            if (op == 5)
            {
                double variable = Convert.ToDouble(textBox1.Text);
                variable = variable * variable;
                textBox1.Text = variable.ToString();
            }
           
            //textBox1.Text = variable;
            //switch (op)
            //{
            //   case 1:{textBox1.Text = (variable + Convert.ToInt32(textBox1.Text)).ToString();}
            //case 2:{textBox1.Text = (variable - Convert.ToInt32(textBox1.Text)).ToString();}
            //case 3:{textBox1.Text = (variable * Convert.ToInt32(textBox1.Text)).ToString();}
            //case 4:{textBox1.Text = (variable / Convert.ToInt32(textBox1.Text)).ToString();}
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            op = 2;
            if (igual == 0)
            {
                variable = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                igual = 0;
            }

            textBox1.Text = "";
        }

        private void btnproducto_Click(object sender, EventArgs e)
        {
            op = 3;
            if (igual == 0)
            {
                variable = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                igual = 0;
            }

            textBox1.Text = "";
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            op = 4;
            if (igual == 0)
            {
                variable = Convert.ToDouble(textBox1.Text);

            }
            else
            {
                igual = 0;
            }

            textBox1.Text = "";

        }

        private void btnpotencia_Click(object sender, EventArgs e)
        {

            op = 5;
            if (igual == 0)
            {
                variable = Convert.ToDouble(textBox1.Text);
                double local= Convert.ToDouble(textBox1.Text);
                variable = variable * variable;
                textBox1.Text = variable.ToString();
            }
            else
            {
                igual = 0;
            }

            //textBox1.Text = "";
        }

        private void btninversa_Click(object sender, EventArgs e)
        {

            op = 6;
            if (igual == 0)
            {
                variable = Convert.ToDouble(textBox1.Text);

                double local = Convert.ToDouble(textBox1.Text);
                variable = 1 / variable;
                textBox1.Text = variable.ToString();
            }
                
            else
            {
                igual = 0;
            }

            //textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcalculadora_Load(object sender, EventArgs e)
        {
            CenterToScreen();



        }
    }
}
