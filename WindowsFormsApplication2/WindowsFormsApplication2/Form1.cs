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
        private int sumaEntrada(int a, int b, int c) {
            c = a + b;
            a = 100;
            b = 200;
            return c;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int resultado = sumaEntrada(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), Int32.Parse(textBox3.Text))
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
