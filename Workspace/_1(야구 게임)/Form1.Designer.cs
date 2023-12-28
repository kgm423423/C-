namespace C_Workspace
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
            this.Display = new System.Windows.Forms.Label();
            this.InputBtn = new System.Windows.Forms.Button();
            this.NumBox1 = new System.Windows.Forms.TextBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.NumList = new System.Windows.Forms.ListBox();
            this.ScoreList = new System.Windows.Forms.ListBox();
            this.NumBox2 = new System.Windows.Forms.TextBox();
            this.NumBox3 = new System.Windows.Forms.TextBox();
            this.NumBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Display.AutoSize = true;
            this.Display.Font = new System.Drawing.Font("굴림", 16F);
            this.Display.Location = new System.Drawing.Point(190, 98);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(281, 32);
            this.Display.TabIndex = 0;
            this.Display.Text = "게임을 시작합니다";
            this.Display.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // InputBtn
            // 
            this.InputBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InputBtn.AutoSize = true;
            this.InputBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.InputBtn.Font = new System.Drawing.Font("굴림", 16F);
            this.InputBtn.Location = new System.Drawing.Point(274, 224);
            this.InputBtn.Name = "InputBtn";
            this.InputBtn.Size = new System.Drawing.Size(120, 44);
            this.InputBtn.TabIndex = 1;
            this.InputBtn.Text = "입력 ";
            this.InputBtn.UseVisualStyleBackColor = false;
            this.InputBtn.Click += new System.EventHandler(this.InputBtn_Click);
            // 
            // NumBox1
            // 
            this.NumBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumBox1.Font = new System.Drawing.Font("굴림", 16F);
            this.NumBox1.Location = new System.Drawing.Point(233, 162);
            this.NumBox1.Name = "NumBox1";
            this.NumBox1.Size = new System.Drawing.Size(44, 44);
            this.NumBox1.TabIndex = 2;
            // 
            // StartBtn
            // 
            this.StartBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StartBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.StartBtn.Font = new System.Drawing.Font("굴림", 16F);
            this.StartBtn.Location = new System.Drawing.Point(183, 30);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(300, 44);
            this.StartBtn.TabIndex = 3;
            this.StartBtn.Text = "게임시작";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // NumList
            // 
            this.NumList.FormattingEnabled = true;
            this.NumList.ItemHeight = 18;
            this.NumList.Location = new System.Drawing.Point(12, 30);
            this.NumList.Name = "NumList";
            this.NumList.Size = new System.Drawing.Size(120, 238);
            this.NumList.TabIndex = 4;
            this.NumList.SelectedIndexChanged += new System.EventHandler(this.NumList_SelectedIndexChanged);
            // 
            // ScoreList
            // 
            this.ScoreList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoreList.FormattingEnabled = true;
            this.ScoreList.ItemHeight = 18;
            this.ScoreList.Location = new System.Drawing.Point(536, 30);
            this.ScoreList.Name = "ScoreList";
            this.ScoreList.Size = new System.Drawing.Size(120, 238);
            this.ScoreList.TabIndex = 5;
            // 
            // NumBox2
            // 
            this.NumBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumBox2.Font = new System.Drawing.Font("굴림", 16F);
            this.NumBox2.Location = new System.Drawing.Point(283, 162);
            this.NumBox2.Name = "NumBox2";
            this.NumBox2.Size = new System.Drawing.Size(44, 44);
            this.NumBox2.TabIndex = 6;
            // 
            // NumBox3
            // 
            this.NumBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumBox3.Font = new System.Drawing.Font("굴림", 16F);
            this.NumBox3.Location = new System.Drawing.Point(333, 162);
            this.NumBox3.Name = "NumBox3";
            this.NumBox3.Size = new System.Drawing.Size(44, 44);
            this.NumBox3.TabIndex = 7;
            // 
            // NumBox4
            // 
            this.NumBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumBox4.Font = new System.Drawing.Font("굴림", 16F);
            this.NumBox4.Location = new System.Drawing.Point(383, 162);
            this.NumBox4.Name = "NumBox4";
            this.NumBox4.Size = new System.Drawing.Size(44, 44);
            this.NumBox4.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 330);
            this.Controls.Add(this.NumBox4);
            this.Controls.Add(this.NumBox3);
            this.Controls.Add(this.NumBox2);
            this.Controls.Add(this.ScoreList);
            this.Controls.Add(this.NumList);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.NumBox1);
            this.Controls.Add(this.InputBtn);
            this.Controls.Add(this.Display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Display;
        private System.Windows.Forms.Button InputBtn;
        private System.Windows.Forms.TextBox NumBox1;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.ListBox NumList;
        private System.Windows.Forms.ListBox ScoreList;
        private System.Windows.Forms.TextBox NumBox2;
        private System.Windows.Forms.TextBox NumBox3;
        private System.Windows.Forms.TextBox NumBox4;
    }
}

