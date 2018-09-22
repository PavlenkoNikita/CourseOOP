using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double angle = Convert.ToDouble(textBox3.Text);

            Right_triangle right = new Right_triangle(a, b, angle);
            Isosceles_triangle isosceles = new Isosceles_triangle(a, b, angle);
            Equilateral_triangle equilateral = new Equilateral_triangle(a, b, angle);

            label1.Text = $"Right:\na = {right.A}\nb = {right.B}\n angle = {right.Angle}\nPerimitr = {right.Perimetr()}\nSquare = {right.Square()}\n";
            label2.Text = $"Isosceles:\na = {isosceles.A}\nb = {isosceles.B}\n angle = {isosceles.Angle}\nPerimitr = {isosceles.Perimetr()}\nSquare = {right.Square()}\n";
            label3.Text = $"Equilateral:\na = {equilateral.A}\nb = {equilateral.B}\n angle = {equilateral.Angle}\nPerimitr = {equilateral.Perimetr()}\nSquare = {equilateral.Square()}\n";
        }
    }
}
