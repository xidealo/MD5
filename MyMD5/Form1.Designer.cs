namespace MyMD5
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
            this.TB_TextForMD5 = new System.Windows.Forms.TextBox();
            this.BT_GoMD5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_PathForFails = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CHB_File = new System.Windows.Forms.CheckBox();
            this.CHB_Text = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TB_TextForMD5
            // 
            this.TB_TextForMD5.Location = new System.Drawing.Point(252, 224);
            this.TB_TextForMD5.Name = "TB_TextForMD5";
            this.TB_TextForMD5.Size = new System.Drawing.Size(250, 20);
            this.TB_TextForMD5.TabIndex = 0;
            this.TB_TextForMD5.Text = "hi";
            // 
            // BT_GoMD5
            // 
            this.BT_GoMD5.Location = new System.Drawing.Point(338, 263);
            this.BT_GoMD5.Name = "BT_GoMD5";
            this.BT_GoMD5.Size = new System.Drawing.Size(75, 23);
            this.BT_GoMD5.TabIndex = 1;
            this.BT_GoMD5.Text = "MD5";
            this.BT_GoMD5.UseVisualStyleBackColor = true;
            this.BT_GoMD5.Click += new System.EventHandler(this.BT_GoMD5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(252, 313);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(282, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ввести текст для вычисления хэша";
            // 
            // TB_PathForFails
            // 
            this.TB_PathForFails.Location = new System.Drawing.Point(252, 165);
            this.TB_PathForFails.Name = "TB_PathForFails";
            this.TB_PathForFails.Size = new System.Drawing.Size(250, 20);
            this.TB_PathForFails.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(260, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ввести путь до файла для вычисления хэша";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(360, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Хэш";
            // 
            // CHB_File
            // 
            this.CHB_File.AutoSize = true;
            this.CHB_File.Location = new System.Drawing.Point(508, 167);
            this.CHB_File.Name = "CHB_File";
            this.CHB_File.Size = new System.Drawing.Size(138, 17);
            this.CHB_File.TabIndex = 7;
            this.CHB_File.Text = "Вычислить хэш файла";
            this.CHB_File.UseVisualStyleBackColor = true;
            this.CHB_File.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CHB_Text
            // 
            this.CHB_Text.AutoSize = true;
            this.CHB_Text.Location = new System.Drawing.Point(508, 224);
            this.CHB_Text.Name = "CHB_Text";
            this.CHB_Text.Size = new System.Drawing.Size(141, 17);
            this.CHB_Text.TabIndex = 8;
            this.CHB_Text.Text = "Вычислить хэш строки";
            this.CHB_Text.UseVisualStyleBackColor = true;
            this.CHB_Text.CheckedChanged += new System.EventHandler(this.CHB_Text_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.CHB_Text);
            this.Controls.Add(this.CHB_File);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_PathForFails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BT_GoMD5);
            this.Controls.Add(this.TB_TextForMD5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_TextForMD5;
        private System.Windows.Forms.Button BT_GoMD5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_PathForFails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CHB_File;
        private System.Windows.Forms.CheckBox CHB_Text;
    }
}

