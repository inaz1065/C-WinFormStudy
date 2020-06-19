using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 윈폼_실습_004___ListControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            if(TextBox_Language.Text == "")
            {
                MessageBox.Show("내용을 입력해주세요");
            }
            else if (ListBox_Language.Items.IndexOf(TextBox_Language.Text) >= 0)
            {
                MessageBox.Show("중복되는 아이템을 넣을 수 없습니다");
            }
            else
            {
                ListBox_Language.Items.Add(TextBox_Language.Text);
                ComboBox_Language.Items.Add(TextBox_Language.Text);
            }
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            int deleteIndex = ListBox_Language.Items.IndexOf(TextBox_Language.Text);
            if (deleteIndex >= 0)
            {
                ListBox_Language.Items.RemoveAt(deleteIndex);
                ComboBox_Language.Items.RemoveAt(deleteIndex);
            }
        }

        private void ListBox_Language_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ListBox_Language.SelectedIndex >= 0)
            {
                TextBox_Language.Text = ListBox_Language.SelectedItem.ToString();
            }
        }

        private void ComboBox_Language_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ComboBox_Language.SelectedIndex >= 0)
            {
                Label_Selected.Text = "결과 : " + ComboBox_Language.SelectedItem.ToString();
            }
        }

        private void CheckedListBox_Hobby_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button_Hobby_Click(object sender, EventArgs e)
        {
            string strTemp = "";
            foreach(var item in CheckedListBox_Hobby.CheckedItems)
            {
                strTemp += item.ToString() + " ";
            }
            MessageBox.Show($"당신의 취미는 {strTemp}입니다");
        }

        private void CheckedListBox_Hobby_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(e.NewValue == CheckState.Checked && CheckedListBox_Hobby.CheckedItems.Count >= 3)
            {
                e.NewValue = CheckState.Unchecked;
                MessageBox.Show("최대 3개까지만 선택 가능합니다");
            }
        }
    }
}
