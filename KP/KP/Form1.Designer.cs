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
            this.txtBtn_A = new System.Windows.Forms.TextBox();
            this.txtBtn_B = new System.Windows.Forms.TextBox();
            this.txtBtn_Angle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox_Triangles = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Sum = new System.Windows.Forms.Label();
            this.listBox_Debug = new System.Windows.Forms.ListBox();
            this.btn_saveInFile = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_OutputResult
            // 
            this.btn_OutputResult.Location = new System.Drawing.Point(15, 141);
            this.btn_OutputResult.Name = "btn_OutputResult";
            this.btn_OutputResult.Size = new System.Drawing.Size(135, 52);
            this.btn_OutputResult.TabIndex = 3;
            this.btn_OutputResult.Text = "Вычислить";
            this.btn_OutputResult.UseVisualStyleBackColor = true;
            this.btn_OutputResult.Click += new System.EventHandler(this.btn_OutputResult_Click);
            // 
            // txtBtn_A
            // 
            this.txtBtn_A.Location = new System.Drawing.Point(102, 28);
            this.txtBtn_A.Name = "txtBtn_A";
            this.txtBtn_A.Size = new System.Drawing.Size(163, 22);
            this.txtBtn_A.TabIndex = 6;
            this.txtBtn_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBtn_A_KeyPress);
            // 
            // txtBtn_B
            // 
            this.txtBtn_B.Location = new System.Drawing.Point(102, 55);
            this.txtBtn_B.Name = "txtBtn_B";
            this.txtBtn_B.Size = new System.Drawing.Size(163, 22);
            this.txtBtn_B.TabIndex = 7;
            this.txtBtn_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBtn_A_KeyPress);
            // 
            // txtBtn_Angle
            // 
            this.txtBtn_Angle.Location = new System.Drawing.Point(102, 83);
            this.txtBtn_Angle.Name = "txtBtn_Angle";
            this.txtBtn_Angle.Size = new System.Drawing.Size(163, 22);
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
            this.groupBox2.Location = new System.Drawing.Point(15, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 117);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввод";
            // 
            // listBox_Triangles
            // 
            this.listBox_Triangles.FormattingEnabled = true;
            this.listBox_Triangles.ItemHeight = 16;
            this.listBox_Triangles.Location = new System.Drawing.Point(13, 239);
            this.listBox_Triangles.Name = "listBox_Triangles";
            this.listBox_Triangles.Size = new System.Drawing.Size(285, 164);
            this.listBox_Triangles.TabIndex = 13;
            this.listBox_Triangles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_Triangles_MouseDoubleClick);
            this.listBox_Triangles.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.listBox1_PreviewKeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Сумма площадей треугольников:";
            // 
            // label_Sum
            // 
            this.label_Sum.AutoSize = true;
            this.label_Sum.Location = new System.Drawing.Point(243, 206);
            this.label_Sum.Name = "label_Sum";
            this.label_Sum.Size = new System.Drawing.Size(16, 17);
            this.label_Sum.TabIndex = 15;
            this.label_Sum.Text = "0";
            // 
            // listBox_Debug
            // 
            this.listBox_Debug.FormattingEnabled = true;
            this.listBox_Debug.ItemHeight = 16;
            this.listBox_Debug.Location = new System.Drawing.Point(313, 28);
            this.listBox_Debug.Name = "listBox_Debug";
            this.listBox_Debug.Size = new System.Drawing.Size(193, 372);
            this.listBox_Debug.TabIndex = 16;
            // 
            // btn_saveInFile
            // 
            this.btn_saveInFile.Location = new System.Drawing.Point(156, 141);
            this.btn_saveInFile.Name = "btn_saveInFile";
            this.btn_saveInFile.Size = new System.Drawing.Size(142, 52);
            this.btn_saveInFile.TabIndex = 17;
            this.btn_saveInFile.Text = "Сохранить в файл";
            this.btn_saveInFile.UseVisualStyleBackColor = true;
            this.btn_saveInFile.Click += new System.EventHandler(this.btn_saveInFile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Логи(Debug)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 410);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_saveInFile);
            this.Controls.Add(this.listBox_Debug);
            this.Controls.Add(this.label_Sum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox_Triangles);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_OutputResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "OOP";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_OutputResult;
        private System.Windows.Forms.TextBox txtBtn_A;
        private System.Windows.Forms.TextBox txtBtn_B;
        private System.Windows.Forms.TextBox txtBtn_Angle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox_Triangles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Sum;
        private System.Windows.Forms.ListBox listBox_Debug;
        private System.Windows.Forms.Button btn_saveInFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label5;
    }
}

