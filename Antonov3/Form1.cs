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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double a = Convert.ToDouble(textBox4.Text);

            textBox5.Text = "Работу выполнил Антонов П. А." + Environment.NewLine;

            double x = x0;
            while(x<=(xk+dx/2))
            {
                double y = a * Math.Log(x);
                string strOut = String.Format("x={0,5} | y={1:f4}", x, y);
                textBox5.Text += strOut + Environment.NewLine;
                x = x + dx;
            }
        }
    }
}
