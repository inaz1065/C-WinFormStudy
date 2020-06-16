namespace 윈폼_실습_005___Dialog
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
            this.Button_ShowForm2 = new System.Windows.Forms.Button();
            this.Button_ShowMessage = new System.Windows.Forms.Button();
            this.TextBox_OpenFile = new System.Windows.Forms.TextBox();
            this.Button_FileOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.Button_ColorChange = new System.Windows.Forms.Button();
            this.colorDialog_Form = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // Button_ShowForm2
            // 
            this.Button_ShowForm2.Location = new System.Drawing.Point(30, 30);
            this.Button_ShowForm2.Name = "Button_ShowForm2";
            this.Button_ShowForm2.Size = new System.Drawing.Size(200, 50);
            this.Button_ShowForm2.TabIndex = 0;
            this.Button_ShowForm2.Text = "NewFormPopUp";
            this.Button_ShowForm2.UseVisualStyleBackColor = true;
            this.Button_ShowForm2.Click += new System.EventHandler(this.Button_ShowForm2_Click);
            // 
            // Button_ShowMessage
            // 
            this.Button_ShowMessage.Location = new System.Drawing.Point(30, 110);
            this.Button_ShowMessage.Name = "Button_ShowMessage";
            this.Button_ShowMessage.Size = new System.Drawing.Size(200, 50);
            this.Button_ShowMessage.TabIndex = 1;
            this.Button_ShowMessage.Text = "MessagePopUp";
            this.Button_ShowMessage.UseVisualStyleBackColor = true;
            this.Button_ShowMessage.Click += new System.EventHandler(this.Button_ShowMessage_Click);
            // 
            // TextBox_OpenFile
            // 
            this.TextBox_OpenFile.Location = new System.Drawing.Point(270, 30);
            this.TextBox_OpenFile.Multiline = true;
            this.TextBox_OpenFile.Name = "TextBox_OpenFile";
            this.TextBox_OpenFile.ReadOnly = true;
            this.TextBox_OpenFile.Size = new System.Drawing.Size(550, 130);
            this.TextBox_OpenFile.TabIndex = 2;
            // 
            // Button_FileOpen
            // 
            this.Button_FileOpen.Location = new System.Drawing.Point(850, 30);
            this.Button_FileOpen.Name = "Button_FileOpen";
            this.Button_FileOpen.Size = new System.Drawing.Size(100, 30);
            this.Button_FileOpen.TabIndex = 3;
            this.Button_FileOpen.Text = "Open";
            this.Button_FileOpen.UseVisualStyleBackColor = true;
            this.Button_FileOpen.Click += new System.EventHandler(this.Button_FileOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(850, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Button_ColorChange
            // 
            this.Button_ColorChange.Location = new System.Drawing.Point(850, 130);
            this.Button_ColorChange.Name = "Button_ColorChange";
            this.Button_ColorChange.Size = new System.Drawing.Size(100, 30);
            this.Button_ColorChange.TabIndex = 5;
            this.Button_ColorChange.Text = "ColorChange";
            this.Button_ColorChange.UseVisualStyleBackColor = true;
            this.Button_ColorChange.Click += new System.EventHandler(this.Button_ColorChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.Button_ColorChange);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Button_FileOpen);
            this.Controls.Add(this.TextBox_OpenFile);
            this.Controls.Add(this.Button_ShowMessage);
            this.Controls.Add(this.Button_ShowForm2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_ShowForm2;
        private System.Windows.Forms.Button Button_ShowMessage;
        private System.Windows.Forms.TextBox TextBox_OpenFile;
        private System.Windows.Forms.Button Button_FileOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Button_ColorChange;
        private System.Windows.Forms.ColorDialog colorDialog_Form;
    }
}

