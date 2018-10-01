using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP
{
    public partial class Form1 : Form
    {
        private int counter;
        private Regex format = new Regex(@"^\d+,?\d*$");

        public Form1()
        {
            InitializeComponent();
            counter = 0;
            txtBtn_B.Enabled = false;
            txtBtn_Angle.Enabled = false;
        }

        private void btn_OutputResult_Click(object sender, EventArgs e)
        {
            if (txtBtn_A.Text == "0" || txtBtn_B.Text == "0")
            {
                return;
            }
            double a; 
            double b; 
            double angle;

            
            string nameTriangle = "Треугольник " + (++counter) + " ";
                        
            if (rdBtn_Equilateral.Checked)
            {
                a = Convert.ToDouble(txtBtn_A.Text);
                listBox1.Items.Add(nameTriangle + "(Правильный)");
                Equilateral_triangle equilateral = new Equilateral_triangle(nameTriangle, a);
                MessageBox.Show($"Равносторонний треугольник со стороной {a}." +
                                $"\nПериметр: {equilateral.Perimetr()} " +
                                $"\nПлощадь: {equilateral.Square()}", 
                                "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdBtn_Isosceles.Checked)
            {
                a = Convert.ToDouble(txtBtn_A.Text);
                angle = Convert.ToDouble(txtBtn_Angle.Text);
                listBox1.Items.Add(nameTriangle + "(Равнобедренный)");
                Isosceles_triangle isosceles = new Isosceles_triangle(nameTriangle, a, angle);
                MessageBox.Show($"Равнобедренный треугольник со сторонами {a} и углом между ними {angle}°." +
                                $"\nПериметр: {isosceles.Perimetr()} " +
                                $"\nПлощадь: {isosceles.Square()}",
                                "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdBtn_Right.Checked)
            {
                a = Convert.ToDouble(txtBtn_A.Text);
                b = Convert.ToDouble(txtBtn_B.Text);
                listBox1.Items.Add(nameTriangle + "(Прямоугольный)");
                Right_triangle right = new Right_triangle(nameTriangle, a, b);
                MessageBox.Show($"Равнобедренный треугольник с катетами {a} и {b}." +
                                $"\nПериметр: {right.Perimetr()} " +
                                $"\nПлощадь: {right.Square()}",
                                "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdBtn_Arbitrary.Checked)
            {
                a = Convert.ToDouble(txtBtn_A.Text);
                b = Convert.ToDouble(txtBtn_B.Text);
                angle = Convert.ToDouble(txtBtn_Angle.Text);
                listBox1.Items.Add(nameTriangle + "(Произвольный)");
                Arbitrary_triangle arbitrary = new Arbitrary_triangle(nameTriangle, a, b, angle);
                MessageBox.Show($"Произвольный треугольник со сторонами {a} и {b} и углом между ними {angle}°." +
                                $"\nПериметр: {arbitrary.Perimetr()} " +
                                $"\nПлощадь: {arbitrary.Square()}",
                                "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void txtBtn_A_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!format.IsMatch(txtBtn_A.Text + e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void listBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }
    }
}
