using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormPrimera : Form
    {
        public FormPrimera()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] mitabla = { 11, 22, 33, 44, 55, 66 };
            //for (int i = 0; i < 6; i++)
            //{
            //    resultado.Text += " " + mitabla[i];
            //}
            foreach (int numero in mitabla ){
                resultado.Text += " "+numero;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
