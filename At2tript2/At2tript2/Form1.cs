using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At2tript2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int altura, peso;
            altura = Convert.ToInt32(txtAltura.Text);
            peso = Convert.ToInt32(txtPeso.Text);
            if (peso <= 6 && altura <= 10)
            {
                MessageBox.Show("Pode passar encima da ponte e enbaixo");
            }
            else if (peso <= 6 && altura > 10)
            {
                MessageBox.Show("Não pode passar enbaixo da ponte mas pode passar encima");
            }
            else if (peso > 6 && altura <= 10)
            {
                MessageBox.Show("Pode passar enbaixo da ponte mas não encima");
            }
            else if (peso > 6 && altura > 10)
            {
                MessageBox.Show("Não pode passar enbaixo da ponte nem encima");
            }
            else if (peso == 6 && altura == 10)
            {
                MessageBox.Show("Pode passar encima da ponte e enbaixo");
            }  
        }
    }
}
