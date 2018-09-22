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
            double a = Convert.ToDouble(txtBtn_A.Text);
            double b = Convert.ToDouble(txtBtn_B.Text);
            double angle = Convert.ToDouble(txtBtn_Angle.Text);

            Right_triangle right = new Right_triangle(a, b, angle);
            Isosceles_triangle isosceles = new Isosceles_triangle(a, b, angle);
            Equilateral_triangle equilateral = new Equilateral_triangle(a, b, angle);


        }

        private void TriangleTypeChanged(object sender, EventArgs e)
        {
            txtBtn_B.Enabled = true;
            txtBtn_Angle.Enabled = true;

            if (rdBtn_Equilateral.Checked)
            {
                txtBtn_B.Enabled = false;
                txtBtn_Angle.Enabled = false;
            }
            else if (rdBtn_Isosceles.Checked) txtBtn_B.Enabled = false;
            else if (rdBtn_Right.Checked) txtBtn_Angle.Enabled = false;
        }
    }
}
