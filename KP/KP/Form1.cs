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
        //string nameTriangle = "";
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

            //nameTriangle = "Треугольник " + (++counter) + " ";
                        
            if (rdBtn_Equilateral.Checked)
            {
                a = Convert.ToDouble(txtBtn_A.Text);

                OutputCalcResult(new Equilateral_triangle(a));
            }
            else if (rdBtn_Isosceles.Checked)
            {
                a = Convert.ToDouble(txtBtn_A.Text);
                angle = Convert.ToDouble(txtBtn_Angle.Text);

                OutputCalcResult(new Isosceles_triangle(a, angle));
            }
            else if (rdBtn_Right.Checked)
            {
                a = Convert.ToDouble(txtBtn_A.Text);
                b = Convert.ToDouble(txtBtn_B.Text);

                OutputCalcResult(new Right_triangle(a, b));
            }
            else if (rdBtn_Arbitrary.Checked)
            {
                a = Convert.ToDouble(txtBtn_A.Text);
                b = Convert.ToDouble(txtBtn_B.Text);
                angle = Convert.ToDouble(txtBtn_Angle.Text);

                OutputCalcResult(new Arbitrary_triangle(a, b, angle));
            }

            label_Sum.Text = string.Format("{0:f2}", picture.SumSquare());

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

            listBox_Triangles.Items.Add($"Треугольник №{++counter} ({triangle.Type})");

            if (triangle is Equilateral_triangle)
            {
                triangleInfo = "Равносторонний треугольник со стороной " + txtBtn_A.Text + ".";
            }
            else if (triangle is Isosceles_triangle)
            {
                triangleInfo = "Равнобедренный треугольник со сторонами " + txtBtn_A.Text + " и углом между ними " + txtBtn_Angle.Text + "°.";
            }
            else if (triangle is Right_triangle)
            {
                triangleInfo = "Прямоугольный треугольник с катетами " + txtBtn_A.Text + " и " + txtBtn_B.Text + ".";
            }
            else
            {
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
                picture.Remove(listBox_Triangles.SelectedIndex);
                listBox_Triangles.Items.Remove(listBox_Triangles.SelectedItem);
                label_Sum.Text = string.Format("{0:f2}", picture.SumSquare());
            }
        }

        private void listBox_Triangles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBox_Triangles.SelectedIndex;

            if (index == -1) return;

            MessageBox.Show(picture.Array[index].GetTriangleInfo(), "Информация", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void Clear()
        {
            txtBtn_A.Clear();
            txtBtn_B.Clear();
            txtBtn_Angle.Clear();
        }
    }
}
