using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 윈폼_실습_002___시계
{
    public partial class ClockForm : Form
    {
        public ClockForm()
        {
            InitializeComponent();
            label_TimeCurrent.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Timer_Sec_Tick(object sender, EventArgs e)
        {
            label_TimeCurrent.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("정말로 종료하시겠습니까?", "경고",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
