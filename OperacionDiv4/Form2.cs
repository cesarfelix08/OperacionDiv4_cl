using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionDiv4
{
    internal class Form2
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                cldivision cldivision = new cldivision(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
                textBox3.Text = cldivision.dividir().ToString();
            }
        }
    }

}
