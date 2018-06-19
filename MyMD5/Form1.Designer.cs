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
            this.SuspendLayout();
            // 
            // TB_TextForMD5
            // 
            this.TB_TextForMD5.Location = new System.Drawing.Point(252, 224);
            this.TB_TextForMD5.Name = "TB_TextForMD5";
            this.TB_TextForMD5.Size = new System.Drawing.Size(250, 20);
            this.TB_TextForMD5.TabIndex = 0;
            // 
            // BT_GoMD5
            // 
            this.BT_GoMD5.Location = new System.Drawing.Point(336, 250);
            this.BT_GoMD5.Name = "BT_GoMD5";
            this.BT_GoMD5.Size = new System.Drawing.Size(75, 23);
            this.BT_GoMD5.TabIndex = 1;
            this.BT_GoMD5.Text = "MD5";
            this.BT_GoMD5.UseVisualStyleBackColor = true;
            this.BT_GoMD5.Click += new System.EventHandler(this.BT_GoMD5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 511);
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
    }
}

