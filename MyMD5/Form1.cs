using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace MyMD5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TB_PathForFails.Enabled = false;
            TB_TextForMD5.Enabled = false;
        }

        string text = "";
        MyMD5 myMD5 = new MyMD5();

        private void BT_GoMD5_Click(object sender, EventArgs e)
        {
            if (CheckBt())
            {
                text = TB_PathForFails.Text;

                try
                {
                    using (FileStream fs = System.IO.File.OpenRead(text))
                    {
                        byte[] fileData = new byte[fs.Length];
                        fs.Read(fileData, 0, (int)fs.Length);
                        textBox1.Text = myMD5.Processing(fileData).ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("Путь к файлу указан неверно, проверьте расширение");
                }

            }
            else
            {
                text = TB_TextForMD5.Text;
                textBox1.Text = myMD5.Processing(text).ToString();
            }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CHB_File.Checked == true) TB_PathForFails.Enabled = true;
            else TB_PathForFails.Enabled = false;
        }

        private void CHB_Text_CheckedChanged(object sender, EventArgs e)
        {
            if (CHB_Text.Checked == true) TB_TextForMD5.Enabled = true;
            else TB_TextForMD5.Enabled = false;
        }

        private bool CheckBt()
        {
            if (CHB_File.Checked == true) return true;
            if (CHB_Text.Checked == true) return false;
            return false;

        }


    }
}
