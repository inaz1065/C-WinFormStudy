namespace 윈폼_실습_004___ListControl
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBox_Language = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_Language = new System.Windows.Forms.TextBox();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.ComboBox_Language = new System.Windows.Forms.ComboBox();
            this.Label_Selected = new System.Windows.Forms.Label();
            this.CheckedListBox_Hobby = new System.Windows.Forms.CheckedListBox();
            this.Button_Hobby = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListBox_Language
            // 
            this.ListBox_Language.FormattingEnabled = true;
            this.ListBox_Language.ItemHeight = 15;
            this.ListBox_Language.Location = new System.Drawing.Point(33, 100);
            this.ListBox_Language.Name = "ListBox_Language";
            this.ListBox_Language.ScrollAlwaysVisible = true;
            this.ListBox_Language.Size = new System.Drawing.Size(317, 244);
            this.ListBox_Language.TabIndex = 0;
            this.ListBox_Language.SelectedIndexChanged += new System.EventHandler(this.ListBox_Language_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "언어 :";
            // 
            // TextBox_Language
            // 
            this.TextBox_Language.Location = new System.Drawing.Point(100, 25);
            this.TextBox_Language.Name = "TextBox_Language";
            this.TextBox_Language.Size = new System.Drawing.Size(250, 25);
            this.TextBox_Language.TabIndex = 2;
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(400, 100);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(100, 30);
            this.Button_Add.TabIndex = 3;
            this.Button_Add.Text = "추가";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.Location = new System.Drawing.Point(400, 150);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(100, 30);
            this.Button_Delete.TabIndex = 4;
            this.Button_Delete.Text = "제거";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // ComboBox_Language
            // 
            this.ComboBox_Language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Language.FormattingEnabled = true;
            this.ComboBox_Language.Location = new System.Drawing.Point(33, 365);
            this.ComboBox_Language.Name = "ComboBox_Language";
            this.ComboBox_Language.Size = new System.Drawing.Size(317, 23);
            this.ComboBox_Language.TabIndex = 5;
            this.ComboBox_Language.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Language_SelectedIndexChanged);
            // 
            // Label_Selected
            // 
            this.Label_Selected.AutoSize = true;
            this.Label_Selected.Location = new System.Drawing.Point(397, 368);
            this.Label_Selected.Name = "Label_Selected";
            this.Label_Selected.Size = new System.Drawing.Size(52, 15);
            this.Label_Selected.TabIndex = 6;
            this.Label_Selected.Text = "결과 : ";
            // 
            // CheckedListBox_Hobby
            // 
            this.CheckedListBox_Hobby.CheckOnClick = true;
            this.CheckedListBox_Hobby.FormattingEnabled = true;
            this.CheckedListBox_Hobby.Items.AddRange(new object[] {
            "축구",
            "야구",
            "농구",
            "수영",
            "스키",
            "독서",
            "악기연주",
            "음악감상",
            "영화감상",
            "게임",
            "공예",
            "그림",
            "우표수집"});
            this.CheckedListBox_Hobby.Location = new System.Drawing.Point(533, 100);
            this.CheckedListBox_Hobby.MultiColumn = true;
            this.CheckedListBox_Hobby.Name = "CheckedListBox_Hobby";
            this.CheckedListBox_Hobby.Size = new System.Drawing.Size(317, 244);
            this.CheckedListBox_Hobby.TabIndex = 7;
            this.CheckedListBox_Hobby.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBox_Hobby_ItemCheck);
            this.CheckedListBox_Hobby.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox_Hobby_SelectedIndexChanged);
            // 
            // Button_Hobby
            // 
            this.Button_Hobby.Location = new System.Drawing.Point(900, 100);
            this.Button_Hobby.Name = "Button_Hobby";
            this.Button_Hobby.Size = new System.Drawing.Size(100, 30);
            this.Button_Hobby.TabIndex = 8;
            this.Button_Hobby.Text = "button1";
            this.Button_Hobby.UseVisualStyleBackColor = true;
            this.Button_Hobby.Click += new System.EventHandler(this.Button_Hobby_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "취미를 선택하세요";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1032, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Button_Hobby);
            this.Controls.Add(this.CheckedListBox_Hobby);
            this.Controls.Add(this.Label_Selected);
            this.Controls.Add(this.ComboBox_Language);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.TextBox_Language);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBox_Language);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox_Language;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_Language;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.ComboBox ComboBox_Language;
        private System.Windows.Forms.Label Label_Selected;
        private System.Windows.Forms.CheckedListBox CheckedListBox_Hobby;
        private System.Windows.Forms.Button Button_Hobby;
        private System.Windows.Forms.Label label2;
    }
}

