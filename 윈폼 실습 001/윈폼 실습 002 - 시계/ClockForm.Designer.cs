namespace 윈폼_실습_002___시계
{
    partial class ClockForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClockForm));
            this.label_TimeCurrent = new System.Windows.Forms.Label();
            this.Timer_Sec = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_TimeCurrent
            // 
            this.label_TimeCurrent.AutoSize = true;
            this.label_TimeCurrent.Font = new System.Drawing.Font("MS PGothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TimeCurrent.Location = new System.Drawing.Point(12, 9);
            this.label_TimeCurrent.Name = "label_TimeCurrent";
            this.label_TimeCurrent.Size = new System.Drawing.Size(458, 120);
            this.label_TimeCurrent.TabIndex = 0;
            this.label_TimeCurrent.Text = "12:00:00";
            // 
            // Timer_Sec
            // 
            this.Timer_Sec.Enabled = true;
            this.Timer_Sec.Interval = 1000;
            this.Timer_Sec.Tick += new System.EventHandler(this.Timer_Sec_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 143);
            this.Controls.Add(this.label_TimeCurrent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "시계";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_TimeCurrent;
        private System.Windows.Forms.Timer Timer_Sec;
    }
}

