using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 윈폼_실습_001
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Label_Type.Text = "";
        }

        private void Button_Flat_Click(object sender, EventArgs e)
        {
            Label_Type.Text = FlatStyle.Flat.ToString();
        }

        private void Button_Popup_Click(object sender, EventArgs e)
        {
            Label_Type.Text = FlatStyle.Popup.ToString();
        }

        private void Button_Standard_Click(object sender, EventArgs e)
        {
            Label_Type.Text = FlatStyle.Standard.ToString();
        }

        private void Button_System_Click(object sender, EventArgs e)
        {
            Label_Type.Text = FlatStyle.System.ToString();
        }

        private void Button_Press_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString(), "현재 시간");
        }
    }
}
