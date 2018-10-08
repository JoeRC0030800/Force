using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Force
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        double sin(double y)
        {
            return (Math.Sin(y * Math.PI / 180));
        }

        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                double F = Convert.ToDouble(textBox1.Text);
                double A = Convert.ToDouble(textBox2.Text);
                double FX = F * cos(A);
                label4.Text = ("FX =" + FX);
            }
            catch
            {

            }
            
                
        }
    }
}
