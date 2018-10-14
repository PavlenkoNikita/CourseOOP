using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private Regex format = new Regex(@"^\d+,?\d*$");
        Picture picture = new Picture();
        List<string> Logs;

        public Form1()
        {
            InitializeComponent();
//#if DEBUG
//            Width = 682;
//#else 
//            Width = 250;
//#endif
        }

        private void btn_OutputResult_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;

            double a = Convert.ToDouble(txtBtn_A.Text);
            double b = Convert.ToDouble(txtBtn_B.Text);
            double angle = Convert.ToDouble(txtBtn_Angle.Text);
            Logs = picture.Logs;

            if (angle == 60 && a == b)
            {
                OutputCalcResult(new Equilateral_triangle(a, ref Logs));
            }
            else if (a == b)
            {
                OutputCalcResult(new Isosceles_triangle(a, angle, ref Logs));
            }
            else if (angle == 90)
            {
                OutputCalcResult(new Right_triangle(a, b, ref Logs));
            }
            else
            {
                OutputCalcResult(new Arbitrary_triangle(a, b, angle, ref Logs));
            }

            label_Sum.Text = string.Format("{0:f2}", picture.SumSquare());

            OutputLogs();

            Clear();
        }

        public void OutputLogs()
        {
            listBox_Debug.Items.Clear();

            for (var i = Logs.Count - 1; i > 0; i -= 2)
            {
                listBox_Debug.Items.Add(Logs[i - 1]);
                listBox_Debug.Items.Add(Logs[i]);
                listBox_Debug.Items.Add("=====================================================");
            }
        }

        private bool CheckInput()
        {
            double check;

            if (txtBtn_A.Text == "" || txtBtn_B.Text == "" || txtBtn_Angle.Text == "")
            {
                MessageBox.Show("Одно из полей ввода пустое.", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }

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

            MessageBox.Show($"{triangleInfo} \n" +
                             $"\nПериметр: {triangle.Perimetr()} " +
                             $"\nПлощадь: {triangle.Square()}",
                             "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtBtn_A_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox obj = sender as TextBox;

            string checkStr = obj.Text + e.KeyChar;

            if (!format.IsMatch(checkStr) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar) && Convert.ToDouble(checkStr) > 100000)
            {
                e.Handled = true;
            }
        }

        private void listBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                picture.Array[listBox_Triangles.SelectedIndex].Dispose(ref Logs);

                OutputLogs();

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

        private void btn_saveInFile_Click(object sender, EventArgs e)
        {

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            File.WriteAllText(saveFileDialog.FileName, picture.ToString());
        }
    }
}
