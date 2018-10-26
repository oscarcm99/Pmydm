using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int sumaEntrada(int a, int b, int c) {
            c = a + b;
            a = 100;
            b = 200; 
            return c;
        }
        public int sumaEntradaSalida(ref int a, ref int b, ref int c)
        {
            c = a + b;
            a = 100;
            b = 200;
            return c;
        }
        public int sumaSalida(int a, int b, out int c)
        {
            c = a + b;
            a = 100;
            b = 200;
            return c;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = Int32.Parse(textBox1.Text);
            int n2 = Int32.Parse(textBox2.Text);
            int n3 = Int32.Parse(textBox3.Text);
            int resultado = sumaEntrada(n1,n2,n3);
            textBox1.Text = n1.ToString();
            textBox2.Text = n2.ToString();
            textBox3.Text = n3.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1 = Int32.Parse(textBox1.Text);
            int n2 = Int32.Parse(textBox2.Text);
            int n3 = Int32.Parse(textBox3.Text);
            int resultado = sumaEntradaSalida(ref n1, ref n2, ref n3);
            textBox1.Text = n1.ToString();
            textBox2.Text = n2.ToString();
            textBox3.Text = n3.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1 = Int32.Parse(textBox1.Text);
            int n2 = Int32.Parse(textBox2.Text);
            int n3 = Int32.Parse(textBox3.Text);
            int resultado = sumaSalida(n1, n2, out n3);
            textBox1.Text = n1.ToString();
            textBox2.Text = n2.ToString();
            textBox3.Text = n3.ToString();
        }
    }
}
