using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antonov3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.Text = "-1,5";
            textBox2.Text = "3,5";
            textBox3.Text = "0,5";
            textBox4.Text = "-1,25";
            textBox5.Text = "-1,5";
            textBox6.Text = "0,75";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double a = Convert.ToDouble(textBox4.Text);
            double b = Convert.ToDouble(textBox5.Text);
            double c = Convert.ToDouble(textBox6.Text);

            textBoxOut.Text = "Работу выполнил Антонов П. А." + Environment.NewLine;

            double x = x0;
            while (x <= (xk + dx / 2))
            {
                double y = Math.Pow(10, -2) * b * c / x + Math.Cos(Math.Sqrt(Math.Pow(a, 3) * x));
                string strOut = String.Format("x={0,5} | y={1:f4}", x, y);
                textBoxOut.Text += strOut + Environment.NewLine;
                x = x + dx;
            }
        }
    }
}
