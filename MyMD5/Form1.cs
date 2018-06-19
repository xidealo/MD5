using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMD5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string text = "";
        FindMD5 mD5 = new FindMD5();

        private void BT_GoMD5_Click(object sender, EventArgs e)
        {
            text = TB_TextForMD5.Text;
            mD5.GetHash(text);

        }
    }
}
