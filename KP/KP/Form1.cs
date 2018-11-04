using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KP
{
    public partial class Form1 : Form
    {
        private int counter;
        private Regex format;
        private Picture picture;
        private List<string> Logs;
        private Random Rnd;

        public Form1()
        {
            InitializeComponent();

            counter = 0;
            format = new Regex(@"^\d+,?\d*$");
            picture = new Picture();
            Rnd = new Random();
        }

        private void btn_OutputResult_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;

            double a = Convert.ToDouble(txtBtn_A.Text);
            double b = Convert.ToDouble(txtBtn_B.Text);
            double angle = Convert.ToDouble(txtBtn_Angle.Text);

            TriangleTypeDefinition(a, b, angle);

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
                MessageBox.Show("Одно из полей ввода пустое.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!double.TryParse(txtBtn_A.Text, out check) || (txtBtn_B.Text != "" && !double.TryParse(txtBtn_B.Text, out check)) || (txtBtn_Angle.Text != "" && !double.TryParse(txtBtn_Angle.Text, out check)))
            {
                MessageBox.Show("Некорректное значение при вводе.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
                return false;
            }

            if (txtBtn_A.Text == "0" || txtBtn_B.Text == "0")
            {
                MessageBox.Show("Значение длины должно быть больше 0.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
                return false;
            }

            if (txtBtn_Angle.Text != "" && Convert.ToDouble(txtBtn_Angle.Text) >= 180)
            {
                MessageBox.Show("Значение величины угла должно быть меньше 180.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                triangleInfo = "Равносторонний треугольник со сторонами " + triangle.A + ".";
            }
            else if (triangle is Isosceles_triangle)
            {
                triangleInfo = "Равнобедренный треугольник со сторонами " + triangle.A + " и углом между ними " + triangle.Angle + "°.";
            }
            else if (triangle is Right_triangle)
            {
                triangleInfo = "Прямоугольный треугольник с катетами " + triangle.A + " и " + triangle.B + ".";
            }
            else
            {
                triangleInfo = "Произвольный треугольник со сторонами " + triangle.A + " и " + triangle.B + "." + " и углом между ними " + triangle.Angle + "°.";
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
                if (listBox_Triangles.SelectedIndex == -1)
                {
                    return;
                }
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

            MessageBox.Show(picture.Array[index].GetTriangleInfo(), "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Clear()
        {
            txtBtn_A.Clear();
            txtBtn_B.Clear();
            txtBtn_Angle.Clear();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picture.Array.Count == 0)
                MessageBox.Show("Нечего сохранять.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                saveFileDialog.Filter = "Json files (*.json)|*.json";
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                ReadWriteFile.WriteInFile(picture.Array, saveFileDialog.FileName);
            }
        }

        private void сгенерироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            double angle;
            int RndTriangle = Rnd.Next(1, 5);

            if (RndTriangle == 1)
            {
                a = Rnd.Next(1, 500);
                b = a;
                angle = 60;
            }
            else if (RndTriangle == 2)
            {
                a = Rnd.Next(1, 500);
                b = a;
                angle = Rnd.Next(1, 179);
            }
            else if (RndTriangle == 3)
            {
                a = Rnd.Next(1, 500);
                b = Rnd.Next(1, 500); ;
                angle = 90;
            }
            else
            {
                a = Rnd.Next(1, 500);
                b = Rnd.Next(1, 500);
                angle = Rnd.Next(1, 179);
            }

            TriangleTypeDefinition(a, b, angle);

            label_Sum.Text = string.Format("{0:f2}", picture.SumSquare());

            OutputLogs();

            Clear();
        }

        private void TriangleTypeDefinition(double a, double b, double angle)
        {
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
        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logs = picture.Logs;
            openFileDialog.Filter = "Json files (*.json)|*.json";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                ReadWriteFile.ReadFile(ref listBox_Triangles, ref picture, ref counter, openFileDialog.FileName);
                label_Sum.Text = string.Format("{0:f2}", picture.SumSquare());
            }
            catch (FileException error)
            {
                MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SerializationException error)
            {
                MessageBox.Show("Считывание файла не удалось. Проверьте формат файла.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
