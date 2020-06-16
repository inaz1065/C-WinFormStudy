using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 윈폼_실습_003___Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Label_FavoriteFruit.Text = "좋아하는 과일 : ";
        }

        private void CheckBox_Apple_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void CheckBox_Strawberry_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void CheckBox_Orange_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void CheckBox_Banana_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void UpdateLabel()
        {
            Label_FavoriteFruit.Text = "좋아하는 과일 : ";

            if (CheckBox_Apple.Checked)
            {
                Label_FavoriteFruit.Text += CheckBox_Apple.Text + " ";
            }

            if (CheckBox_Strawberry.Checked)
            {
                Label_FavoriteFruit.Text += CheckBox_Strawberry.Text + " ";
            }

            if (CheckBox_Orange.Checked)
            {
                Label_FavoriteFruit.Text += CheckBox_Orange.Text + " ";
            }

            if (CheckBox_Banana.Checked)
            {
                Label_FavoriteFruit.Text += CheckBox_Banana.Text + " ";
            }
        }

        private void RadioButton_Cider_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton_Cider.Checked)
                Label_FavoriteDrink.Text = "좋아하는 음료 : " + RadioButton_Cider.Text;

        }

        private void RadioButton_Cola_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton_Cola.Checked)
                Label_FavoriteDrink.Text = "좋아하는 음료 : " + RadioButton_Cola.Text;
        }

        private void RadioButton_Juice_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton_Juice.Checked)
                Label_FavoriteDrink.Text = "좋아하는 음료 : " + RadioButton_Juice.Text;
        }

        private void RadioButton_Tea_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton_Tea.Checked)
                Label_FavoriteDrink.Text = "좋아하는 음료 : " + RadioButton_Tea.Text;
        }

        private void LinkLabel_Naver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(LinkLabel_Naver.Text);
        }

        private void Button_LogIn_Click(object sender, EventArgs e)
        {
            if(TextBox_ID.Text != "" && TextBox_PW.Text != "")
            {
                TextBox_LogInResult.Text = $"ID : {TextBox_ID.Text}\r\nPW : {TextBox_PW}\r\n"
                                          + "로그인에 성공했습니다";
            }
            else
            {
                TextBox_LogInResult.Text = "로그인에 실패했습니다\r\n"
                                         + "ID와 PW를 모두 입력해주세요";
            }
        }
    }
}
