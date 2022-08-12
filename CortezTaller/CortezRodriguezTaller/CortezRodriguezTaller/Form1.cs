using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CortezRodriguezTaller
{
    public partial class Form1 : Form
    {
        private string mensa;
        private static int conta;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int conta = 0;
            conta += 1;
            mensa = "Ha sumado 1 cifra " + Convert.ToString(conta);
            label1.Text = mensa;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int conta = 0;
            conta += 10;
            mensa = "Ha sumado 10 cifras " + Convert.ToString(conta);
            label1.Text = mensa;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int conta = 0;
            conta += 100;
            mensa = "Ha sumado 100 cifras " + Convert.ToString(conta);
            label1.Text = mensa;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            int numero = random.Next(1, 500);
            Console.WriteLine(numero);
        }
    }
}
 