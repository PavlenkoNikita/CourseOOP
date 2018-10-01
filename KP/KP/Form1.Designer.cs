namespace KP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_OutputResult = new System.Windows.Forms.Button();
            this.rdBtn_Equilateral = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtn_Arbitrary = new System.Windows.Forms.RadioButton();
            this.rdBtn_Right = new System.Windows.Forms.RadioButton();
            this.rdBtn_Isosceles = new System.Windows.Forms.RadioButton();
            this.txtBtn_A = new System.Windows.Forms.TextBox();
            this.txtBtn_B = new System.Windows.Forms.TextBox();
            this.txtBtn_Angle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Sum = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_OutputResult
            // 
            this.btn_OutputResult.Location = new System.Drawing.Point(205, 139);
            this.btn_OutputResult.Name = "btn_OutputResult";
            this.btn_OutputResult.Size = new System.Drawing.Size(185, 52);
            this.btn_OutputResult.TabIndex = 3;
            this.btn_OutputResult.Text = "Вычислить";
            this.btn_OutputResult.UseVisualStyleBackColor = true;
            this.btn_OutputResult.Click += new System.EventHandler(this.btn_OutputResult_Click);
            // 
            // rdBtn_Equilateral
            // 
            this.rdBtn_Equilateral.AutoSize = true;
            this.rdBtn_Equilateral.Location = new System.Drawing.Point(16, 31);
            this.rdBtn_Equilateral.Name = "rdBtn_Equilateral";
            this.rdBtn_Equilateral.Size = new System.Drawing.Size(111, 21);
            this.rdBtn_Equilateral.TabIndex = 4;
            this.rdBtn_Equilateral.Text = "Правильный";
            this.rdBtn_Equilateral.UseVisualStyleBackColor = true;
            this.rdBtn_Equilateral.Click += new System.EventHandler(this.TriangleTypeChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtn_Arbitrary);
            this.groupBox1.Controls.Add(this.rdBtn_Right);
            this.groupBox1.Controls.Add(this.rdBtn_Isosceles);
            this.groupBox1.Controls.Add(this.rdBtn_Equilateral);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 178);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вид треугольника";
            // 
            // rdBtn_Arbitrary
            // 
            this.rdBtn_Arbitrary.AutoSize = true;
            this.rdBtn_Arbitrary.Checked = true;
            this.rdBtn_Arbitrary.Location = new System.Drawing.Point(16, 142);
            this.rdBtn_Arbitrary.Name = "rdBtn_Arbitrary";
            this.rdBtn_Arbitrary.Size = new System.Drawing.Size(126, 21);
            this.rdBtn_Arbitrary.TabIndex = 7;
            this.rdBtn_Arbitrary.TabStop = true;
            this.rdBtn_Arbitrary.Text = "Произвольный";
            this.rdBtn_Arbitrary.UseVisualStyleBackColor = true;
            this.rdBtn_Arbitrary.Click += new System.EventHandler(this.TriangleTypeChanged);
            // 
            // rdBtn_Right
            // 
            this.rdBtn_Right.AutoSize = true;
            this.rdBtn_Right.Location = new System.Drawing.Point(16, 105);
            this.rdBtn_Right.Name = "rdBtn_Right";
            this.rdBtn_Right.Size = new System.Drawing.Size(133, 21);
            this.rdBtn_Right.TabIndex = 6;
            this.rdBtn_Right.Text = "Прямоугольный";
            this.rdBtn_Right.UseVisualStyleBackColor = true;
            this.rdBtn_Right.Click += new System.EventHandler(this.TriangleTypeChanged);
            // 
            // rdBtn_Isosceles
            // 
            this.rdBtn_Isosceles.AutoSize = true;
            this.rdBtn_Isosceles.Location = new System.Drawing.Point(16, 68);
            this.rdBtn_Isosceles.Name = "rdBtn_Isosceles";
            this.rdBtn_Isosceles.Size = new System.Drawing.Size(143, 21);
            this.rdBtn_Isosceles.TabIndex = 5;
            this.rdBtn_Isosceles.Text = "Равнобедренный";
            this.rdBtn_Isosceles.UseVisualStyleBackColor = true;
            this.rdBtn_Isosceles.Click += new System.EventHandler(this.TriangleTypeChanged);
            // 
            // txtBtn_A
            // 
            this.txtBtn_A.Location = new System.Drawing.Point(102, 27);
            this.txtBtn_A.Name = "txtBtn_A";
            this.txtBtn_A.Size = new System.Drawing.Size(68, 22);
            this.txtBtn_A.TabIndex = 6;
            this.txtBtn_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBtn_A_KeyPress);
            // 
            // txtBtn_B
            // 
            this.txtBtn_B.Location = new System.Drawing.Point(102, 55);
            this.txtBtn_B.Name = "txtBtn_B";
            this.txtBtn_B.Size = new System.Drawing.Size(68, 22);
            this.txtBtn_B.TabIndex = 7;
            this.txtBtn_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBtn_A_KeyPress);
            // 
            // txtBtn_Angle
            // 
            this.txtBtn_Angle.Location = new System.Drawing.Point(102, 83);
            this.txtBtn_Angle.Name = "txtBtn_Angle";
            this.txtBtn_Angle.Size = new System.Drawing.Size(68, 22);
            this.txtBtn_Angle.TabIndex = 8;
            this.txtBtn_Angle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBtn_A_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Сторона a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Сторона b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Угол:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBtn_B);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBtn_A);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtBtn_Angle);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(205, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 117);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввод";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 239);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(377, 164);
            this.listBox1.TabIndex = 13;
            this.listBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.listBox1_PreviewKeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Сумма площадей треугольников:";
            // 
            // label_Sum
            // 
            this.label_Sum.AutoSize = true;
            this.label_Sum.Location = new System.Drawing.Point(234, 206);
            this.label_Sum.Name = "label_Sum";
            this.label_Sum.Size = new System.Drawing.Size(16, 17);
            this.label_Sum.TabIndex = 15;
            this.label_Sum.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 417);
            this.Controls.Add(this.label_Sum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_OutputResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "OOP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_OutputResult;
        private System.Windows.Forms.RadioButton rdBtn_Equilateral;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBtn_Arbitrary;
        private System.Windows.Forms.RadioButton rdBtn_Right;
        private System.Windows.Forms.RadioButton rdBtn_Isosceles;
        private System.Windows.Forms.TextBox txtBtn_A;
        private System.Windows.Forms.TextBox txtBtn_B;
        private System.Windows.Forms.TextBox txtBtn_Angle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Sum;
    }
}

