using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 윈폼_실습_006___Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StripMenu_NewFile_Click(object sender, EventArgs e)
        {
            TextBox_Main.Text += StripMenu_NewFile.Text + Environment.NewLine;
        }

        [STAThreadAttribute]
        private void StripMenu_Paste_Click(object sender, EventArgs e)
        {
            TextBox_Main.Text += Clipboard.GetText();
        }

        private void TextBox_Main_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Middle)
            {
                //MessageBox.Show("오른쪽 클릭!");
                ContextMenuStrip.Show();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            StripMenu_NewFile_Click(sender, new EventArgs());
        }
    }
}
