namespace 윈폼_실습_001
{
    partial class MainForm
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
            this.Button_Flat = new System.Windows.Forms.Button();
            this.Button_Popup = new System.Windows.Forms.Button();
            this.Button_Standard = new System.Windows.Forms.Button();
            this.Button_System = new System.Windows.Forms.Button();
            this.Label_Type = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_Flat
            // 
            this.Button_Flat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Button_Flat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Flat.Location = new System.Drawing.Point(100, 35);
            this.Button_Flat.Name = "Button_Flat";
            this.Button_Flat.Size = new System.Drawing.Size(200, 50);
            this.Button_Flat.TabIndex = 0;
            this.Button_Flat.Text = "Flat";
            this.Button_Flat.UseVisualStyleBackColor = false;
            this.Button_Flat.Click += new System.EventHandler(this.Button_Flat_Click);
            // 
            // Button_Popup
            // 
            this.Button_Popup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Popup.Location = new System.Drawing.Point(500, 35);
            this.Button_Popup.Name = "Button_Popup";
            this.Button_Popup.Size = new System.Drawing.Size(200, 50);
            this.Button_Popup.TabIndex = 0;
            this.Button_Popup.Text = "Popup";
            this.Button_Popup.UseVisualStyleBackColor = true;
            this.Button_Popup.Click += new System.EventHandler(this.Button_Popup_Click);
            // 
            // Button_Standard
            // 
            this.Button_Standard.Location = new System.Drawing.Point(100, 125);
            this.Button_Standard.Name = "Button_Standard";
            this.Button_Standard.Size = new System.Drawing.Size(200, 50);
            this.Button_Standard.TabIndex = 0;
            this.Button_Standard.Text = "Standard";
            this.Button_Standard.UseVisualStyleBackColor = true;
            this.Button_Standard.Click += new System.EventHandler(this.Button_Standard_Click);
            // 
            // Button_System
            // 
            this.Button_System.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button_System.Location = new System.Drawing.Point(500, 125);
            this.Button_System.Name = "Button_System";
            this.Button_System.Size = new System.Drawing.Size(200, 50);
            this.Button_System.TabIndex = 0;
            this.Button_System.Text = "System";
            this.Button_System.UseVisualStyleBackColor = true;
            this.Button_System.Click += new System.EventHandler(this.Button_System_Click);
            // 
            // Label_Type
            // 
            this.Label_Type.BackColor = System.Drawing.SystemColors.Control;
            this.Label_Type.Font = new System.Drawing.Font("MS PGothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Type.Location = new System.Drawing.Point(300, 250);
            this.Label_Type.Name = "Label_Type";
            this.Label_Type.Size = new System.Drawing.Size(200, 50);
            this.Label_Type.TabIndex = 1;
            this.Label_Type.Text = "label1";
            this.Label_Type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.Label_Type);
            this.Controls.Add(this.Button_Popup);
            this.Controls.Add(this.Button_System);
            this.Controls.Add(this.Button_Standard);
            this.Controls.Add(this.Button_Flat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Flat;
        private System.Windows.Forms.Button Button_Popup;
        private System.Windows.Forms.Button Button_Standard;
        private System.Windows.Forms.Button Button_System;
        private System.Windows.Forms.Label Label_Type;
    }
}

