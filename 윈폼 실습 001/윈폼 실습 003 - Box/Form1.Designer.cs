namespace 윈폼_실습_003___Box
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
            this.CheckBox_Apple = new System.Windows.Forms.CheckBox();
            this.CheckBox_Strawberry = new System.Windows.Forms.CheckBox();
            this.CheckBox_Orange = new System.Windows.Forms.CheckBox();
            this.CheckBox_Banana = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_FavoriteFruit = new System.Windows.Forms.Label();
            this.RadioButton_Cider = new System.Windows.Forms.RadioButton();
            this.RadioButton_Cola = new System.Windows.Forms.RadioButton();
            this.RadioButton_Juice = new System.Windows.Forms.RadioButton();
            this.RadioButton_Tea = new System.Windows.Forms.RadioButton();
            this.Label_FavoriteDrink = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LinkLabel_Naver = new System.Windows.Forms.LinkLabel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // CheckBox_Apple
            // 
            this.CheckBox_Apple.AutoSize = true;
            this.CheckBox_Apple.Location = new System.Drawing.Point(50, 50);
            this.CheckBox_Apple.Name = "CheckBox_Apple";
            this.CheckBox_Apple.Size = new System.Drawing.Size(59, 19);
            this.CheckBox_Apple.TabIndex = 0;
            this.CheckBox_Apple.Text = "사과";
            this.CheckBox_Apple.UseVisualStyleBackColor = true;
            this.CheckBox_Apple.CheckedChanged += new System.EventHandler(this.CheckBox_Apple_CheckedChanged);
            // 
            // CheckBox_Strawberry
            // 
            this.CheckBox_Strawberry.AutoSize = true;
            this.CheckBox_Strawberry.Location = new System.Drawing.Point(200, 50);
            this.CheckBox_Strawberry.Name = "CheckBox_Strawberry";
            this.CheckBox_Strawberry.Size = new System.Drawing.Size(59, 19);
            this.CheckBox_Strawberry.TabIndex = 1;
            this.CheckBox_Strawberry.Text = "딸기";
            this.CheckBox_Strawberry.UseVisualStyleBackColor = true;
            this.CheckBox_Strawberry.CheckedChanged += new System.EventHandler(this.CheckBox_Strawberry_CheckedChanged);
            // 
            // CheckBox_Orange
            // 
            this.CheckBox_Orange.AutoSize = true;
            this.CheckBox_Orange.Location = new System.Drawing.Point(50, 100);
            this.CheckBox_Orange.Name = "CheckBox_Orange";
            this.CheckBox_Orange.Size = new System.Drawing.Size(74, 19);
            this.CheckBox_Orange.TabIndex = 2;
            this.CheckBox_Orange.Text = "오렌지";
            this.CheckBox_Orange.UseVisualStyleBackColor = true;
            this.CheckBox_Orange.CheckedChanged += new System.EventHandler(this.CheckBox_Orange_CheckedChanged);
            // 
            // CheckBox_Banana
            // 
            this.CheckBox_Banana.AutoSize = true;
            this.CheckBox_Banana.Location = new System.Drawing.Point(200, 100);
            this.CheckBox_Banana.Name = "CheckBox_Banana";
            this.CheckBox_Banana.Size = new System.Drawing.Size(74, 19);
            this.CheckBox_Banana.TabIndex = 3;
            this.CheckBox_Banana.Text = "바나나";
            this.CheckBox_Banana.UseVisualStyleBackColor = true;
            this.CheckBox_Banana.CheckedChanged += new System.EventHandler(this.CheckBox_Banana_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "좋아하는 것";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_FavoriteFruit
            // 
            this.Label_FavoriteFruit.AutoSize = true;
            this.Label_FavoriteFruit.Location = new System.Drawing.Point(50, 150);
            this.Label_FavoriteFruit.Name = "Label_FavoriteFruit";
            this.Label_FavoriteFruit.Size = new System.Drawing.Size(117, 15);
            this.Label_FavoriteFruit.TabIndex = 5;
            this.Label_FavoriteFruit.Text = "좋아하는 과일 : ";
            // 
            // RadioButton_Cider
            // 
            this.RadioButton_Cider.AutoSize = true;
            this.RadioButton_Cider.Location = new System.Drawing.Point(50, 250);
            this.RadioButton_Cider.Name = "RadioButton_Cider";
            this.RadioButton_Cider.Size = new System.Drawing.Size(73, 19);
            this.RadioButton_Cider.TabIndex = 6;
            this.RadioButton_Cider.TabStop = true;
            this.RadioButton_Cider.Text = "사이다";
            this.RadioButton_Cider.UseVisualStyleBackColor = true;
            this.RadioButton_Cider.CheckedChanged += new System.EventHandler(this.RadioButton_Cider_CheckedChanged);
            // 
            // RadioButton_Cola
            // 
            this.RadioButton_Cola.AutoSize = true;
            this.RadioButton_Cola.Location = new System.Drawing.Point(200, 250);
            this.RadioButton_Cola.Name = "RadioButton_Cola";
            this.RadioButton_Cola.Size = new System.Drawing.Size(58, 19);
            this.RadioButton_Cola.TabIndex = 7;
            this.RadioButton_Cola.TabStop = true;
            this.RadioButton_Cola.Text = "콜라";
            this.RadioButton_Cola.UseVisualStyleBackColor = true;
            this.RadioButton_Cola.CheckedChanged += new System.EventHandler(this.RadioButton_Cola_CheckedChanged);
            // 
            // RadioButton_Juice
            // 
            this.RadioButton_Juice.AutoSize = true;
            this.RadioButton_Juice.Location = new System.Drawing.Point(50, 300);
            this.RadioButton_Juice.Name = "RadioButton_Juice";
            this.RadioButton_Juice.Size = new System.Drawing.Size(58, 19);
            this.RadioButton_Juice.TabIndex = 8;
            this.RadioButton_Juice.TabStop = true;
            this.RadioButton_Juice.Text = "주스";
            this.RadioButton_Juice.UseVisualStyleBackColor = true;
            this.RadioButton_Juice.CheckedChanged += new System.EventHandler(this.RadioButton_Juice_CheckedChanged);
            // 
            // RadioButton_Tea
            // 
            this.RadioButton_Tea.AutoSize = true;
            this.RadioButton_Tea.Location = new System.Drawing.Point(200, 300);
            this.RadioButton_Tea.Name = "RadioButton_Tea";
            this.RadioButton_Tea.Size = new System.Drawing.Size(58, 19);
            this.RadioButton_Tea.TabIndex = 9;
            this.RadioButton_Tea.TabStop = true;
            this.RadioButton_Tea.Text = "녹차";
            this.RadioButton_Tea.UseVisualStyleBackColor = true;
            this.RadioButton_Tea.CheckedChanged += new System.EventHandler(this.RadioButton_Tea_CheckedChanged);
            // 
            // Label_FavoriteDrink
            // 
            this.Label_FavoriteDrink.AutoSize = true;
            this.Label_FavoriteDrink.Location = new System.Drawing.Point(50, 350);
            this.Label_FavoriteDrink.Name = "Label_FavoriteDrink";
            this.Label_FavoriteDrink.Size = new System.Drawing.Size(117, 15);
            this.Label_FavoriteDrink.TabIndex = 10;
            this.Label_FavoriteDrink.Text = "좋아하는 음료 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Log In";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password : ";
            // 
            // LinkLabel_Naver
            // 
            this.LinkLabel_Naver.AutoSize = true;
            this.LinkLabel_Naver.Location = new System.Drawing.Point(500, 50);
            this.LinkLabel_Naver.Name = "LinkLabel_Naver";
            this.LinkLabel_Naver.Size = new System.Drawing.Size(125, 15);
            this.LinkLabel_Naver.TabIndex = 16;
            this.LinkLabel_Naver.TabStop = true;
            this.LinkLabel_Naver.Text = "https://naver.com";
            this.LinkLabel_Naver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_Naver_LinkClicked);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(500, 96);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(150, 25);
            this.maskedTextBox1.TabIndex = 17;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(500, 146);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(150, 25);
            this.maskedTextBox2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.LinkLabel_Naver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label_FavoriteDrink);
            this.Controls.Add(this.RadioButton_Tea);
            this.Controls.Add(this.RadioButton_Juice);
            this.Controls.Add(this.RadioButton_Cola);
            this.Controls.Add(this.RadioButton_Cider);
            this.Controls.Add(this.Label_FavoriteFruit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckBox_Banana);
            this.Controls.Add(this.CheckBox_Orange);
            this.Controls.Add(this.CheckBox_Strawberry);
            this.Controls.Add(this.CheckBox_Apple);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBox_Apple;
        private System.Windows.Forms.CheckBox CheckBox_Strawberry;
        private System.Windows.Forms.CheckBox CheckBox_Orange;
        private System.Windows.Forms.CheckBox CheckBox_Banana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_FavoriteFruit;
        private System.Windows.Forms.RadioButton RadioButton_Cider;
        private System.Windows.Forms.RadioButton RadioButton_Cola;
        private System.Windows.Forms.RadioButton RadioButton_Juice;
        private System.Windows.Forms.RadioButton RadioButton_Tea;
        private System.Windows.Forms.Label Label_FavoriteDrink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel LinkLabel_Naver;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
    }
}

