using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 윈폼_실습_005___Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_ShowForm2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();  //form2를 여는데, form2를 종료할 때까지 form1을 건드릴 수 없다
            //form.Show();      //단순히 폼을 연다
        }

        private void Button_ShowMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("눌러버렸군요", "눌러버렸습니다", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button_FileOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "텍스트 파일|*.txt|모든 파일(*.*)|*.*";
            openFileDialog1.Multiselect = true;
            openFileDialog1.ShowDialog();

            foreach(var file in openFileDialog1.FileNames)
            {
                TextBox_OpenFile.Text += file + Environment.NewLine;
            }
        }

        private void Button_ColorChange_Click(object sender, EventArgs e)
        {
            if (colorDialog_Form.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog_Form.Color;
            }

        }
    }
}
