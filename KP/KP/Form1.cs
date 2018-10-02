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
        private int counter = 0;
        string nameTriangle = "";
        private Regex format = new Regex(@"^\d+,?\d*$");
        Picture picture = new Picture();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_OutputResult_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;

            double a; 
            double b; 
            double angle;

            nameTriangle = "Треугольник " + (++counter) + " ";
                        
            if (rdBtn_Equilateral.Checked)
            {
                a = Convert.ToDouble(txtBtn_A.Text);

                OutputCalcResult(new Equilateral_triangle(nameTriangle, a));
            }
            else if (rdBtn_Isosceles.Checked)
            {
                a = Convert.ToDouble(txtBtn_A.Text);
                angle = Convert.ToDouble(txtBtn_Angle.Text);

                OutputCalcResult(new Isosceles_triangle(nameTriangle, a, angle));
            }
            else if (rdBtn_Right.Checked)
            {
                a = Convert.ToDouble(txtBtn_A.Text);
                b = Convert.ToDouble(txtBtn_B.Text);

                OutputCalcResult(new Right_triangle(nameTriangle, a, b));
            }
            else if (rdBtn_Arbitrary.Checked)
            {
                a = Convert.ToDouble(txtBtn_A.Text);
                b = Convert.ToDouble(txtBtn_B.Text);
                angle = Convert.ToDouble(txtBtn_Angle.Text);

                OutputCalcResult(new Arbitrary_triangle(nameTriangle, a, b, angle));
            }

            label_Sum.Text = picture.SumSquare().ToString("#.##");

            Clear();
        }

        private bool CheckInput()
        {
            double check;

            if (!double.TryParse(txtBtn_A.Text, out check) || (txtBtn_B.Text != "" && !double.TryParse(txtBtn_B.Text, out check)) || (txtBtn_Angle.Text != "" && !double.TryParse(txtBtn_Angle.Text, out check)))
            {
                MessageBox.Show("Некорректное значение при вводе.", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Clear();
                return false;
            }

            if (txtBtn_A.Text == "0" || txtBtn_B.Text == "0")
            {
                MessageBox.Show("Значение длины должно быть больше 0.", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Clear();
                return false;
            }

            if (txtBtn_Angle.Text != "" && Convert.ToDouble(txtBtn_Angle.Text) >= 180)
            {
                MessageBox.Show("Значение величины угла должно быть меньше 180.", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtBtn_Angle.Clear();
                return false;
            }

            return true;
        }

        private void OutputCalcResult(Triangle triangle)
        {
            picture.Add(triangle);

            string triangleInfo = "";

            if(triangle is Equilateral_triangle)
            {
                listBox1.Items.Add(nameTriangle + "(Правильный)");
                triangleInfo = "Равносторонний треугольник со стороной " + txtBtn_A.Text + ".";
            }
            else if(triangle is Isosceles_triangle)
            {
                listBox1.Items.Add(nameTriangle + "(Равнобедренный)");
                triangleInfo = "Равнобедренный треугольник со сторонами " + txtBtn_A.Text + " и углом между ними " + txtBtn_Angle.Text + "°.";
            }
            else if(triangle is Right_triangle)
            {
                listBox1.Items.Add(nameTriangle + "(Прямоугольный)");
                triangleInfo = "Прямоугольный треугольник с катетами " + txtBtn_A.Text + " и " + txtBtn_B.Text + ".";
            }
            else
            {
                listBox1.Items.Add(nameTriangle + "(Произвольный)");
                triangleInfo = "Произвольный треугольник со сторонами " + txtBtn_A.Text + " и " + txtBtn_B.Text + "." + " и углом между ними " + txtBtn_Angle.Text + "°.";
            }

            MessageBox.Show( $"{triangleInfo} \n" +
                             $"\nПериметр: {triangle.Perimetr()} " +
                             $"\nПлощадь: {triangle.Square()}",
                             "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Clear()
        {
            txtBtn_A.Clear();
            txtBtn_B.Clear();
            txtBtn_Angle.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
