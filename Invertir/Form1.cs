using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invertir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";

            string invertir, aux;
            int count;

            invertir = textBox1.Text.Trim();
            aux = "";
            count = invertir.Length - 1;


            while(count >= 0)
            {
                aux = aux + invertir[count];
                count = count - 1;
            }
            label2.Text = label2.Text + aux;
        }
    }
}
