namespace WindowsFormsApp2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnPoint = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnAllClear = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnSubtract = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.BtnResult = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Dock = System.Windows.Forms.DockStyle.Top;
            this.Display.Font = new System.Drawing.Font("굴림", 20F);
            this.Display.Location = new System.Drawing.Point(0, 0);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(314, 40);
            this.Display.TabIndex = 0;
            this.Display.Text = "0\r\n";
            this.Display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.BtnPoint, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Btn0, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnAllClear, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Btn9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Btn8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnMultiply, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Btn6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Btn5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Btn4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnDivide, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnAdd, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnSubtract, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Btn7, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 300);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // BtnPoint
            // 
            this.BtnPoint.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnPoint.Font = new System.Drawing.Font("굴림", 20F);
            this.BtnPoint.Location = new System.Drawing.Point(153, 228);
            this.BtnPoint.Name = "BtnPoint";
            this.BtnPoint.Size = new System.Drawing.Size(69, 69);
            this.BtnPoint.TabIndex = 16;
            this.BtnPoint.Text = ".";
            this.BtnPoint.UseVisualStyleBackColor = false;
            this.BtnPoint.Click += new System.EventHandler(this.BtnPoint_Click);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn0.Font = new System.Drawing.Font("굴림", 20F);
            this.Btn0.Location = new System.Drawing.Point(78, 228);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(69, 69);
            this.Btn0.TabIndex = 15;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // BtnAllClear
            // 
            this.BtnAllClear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnAllClear.Font = new System.Drawing.Font("굴림", 15F);
            this.BtnAllClear.Location = new System.Drawing.Point(3, 228);
            this.BtnAllClear.Name = "BtnAllClear";
            this.BtnAllClear.Size = new System.Drawing.Size(69, 69);
            this.BtnAllClear.TabIndex = 14;
            this.BtnAllClear.Text = "AC";
            this.BtnAllClear.UseVisualStyleBackColor = false;
            this.BtnAllClear.Click += new System.EventHandler(this.BtnAllClear_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn9.Font = new System.Drawing.Font("굴림", 20F);
            this.Btn9.Location = new System.Drawing.Point(153, 153);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(69, 69);
            this.Btn9.TabIndex = 12;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn8.Font = new System.Drawing.Font("굴림", 20F);
            this.Btn8.Location = new System.Drawing.Point(78, 153);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(69, 69);
            this.Btn8.TabIndex = 11;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnMultiply.Font = new System.Drawing.Font("굴림", 20F);
            this.BtnMultiply.Location = new System.Drawing.Point(228, 78);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(69, 69);
            this.BtnMultiply.TabIndex = 9;
            this.BtnMultiply.Text = "×";
            this.BtnMultiply.UseVisualStyleBackColor = false;
            this.BtnMultiply.Click += new System.EventHandler(this.BtnMultiply_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn6.Font = new System.Drawing.Font("굴림", 20F);
            this.Btn6.Location = new System.Drawing.Point(153, 78);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(69, 69);
            this.Btn6.TabIndex = 8;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn5.Font = new System.Drawing.Font("굴림", 20F);
            this.Btn5.Location = new System.Drawing.Point(78, 78);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(69, 69);
            this.Btn5.TabIndex = 7;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn4.Font = new System.Drawing.Font("굴림", 20F);
            this.Btn4.Location = new System.Drawing.Point(3, 78);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(69, 69);
            this.Btn4.TabIndex = 6;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // BtnDivide
            // 
            this.BtnDivide.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnDivide.Font = new System.Drawing.Font("굴림", 20F);
            this.BtnDivide.Location = new System.Drawing.Point(228, 3);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(69, 69);
            this.BtnDivide.TabIndex = 5;
            this.BtnDivide.Text = "÷";
            this.BtnDivide.UseVisualStyleBackColor = false;
            this.BtnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn3.Font = new System.Drawing.Font("굴림", 20F);
            this.Btn3.Location = new System.Drawing.Point(153, 3);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(69, 69);
            this.Btn3.TabIndex = 4;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn2.Font = new System.Drawing.Font("굴림", 20F);
            this.Btn2.Location = new System.Drawing.Point(78, 3);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(69, 69);
            this.Btn2.TabIndex = 3;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn1.Font = new System.Drawing.Font("굴림", 20F);
            this.Btn1.Location = new System.Drawing.Point(3, 3);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(69, 69);
            this.Btn1.TabIndex = 2;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnAdd.Font = new System.Drawing.Font("굴림", 20F);
            this.BtnAdd.Location = new System.Drawing.Point(228, 228);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(69, 69);
            this.BtnAdd.TabIndex = 13;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnSubtract
            // 
            this.BtnSubtract.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnSubtract.Font = new System.Drawing.Font("굴림", 20F);
            this.BtnSubtract.Location = new System.Drawing.Point(228, 153);
            this.BtnSubtract.Name = "BtnSubtract";
            this.BtnSubtract.Size = new System.Drawing.Size(69, 69);
            this.BtnSubtract.TabIndex = 17;
            this.BtnSubtract.Text = "-";
            this.BtnSubtract.UseVisualStyleBackColor = false;
            this.BtnSubtract.Click += new System.EventHandler(this.BtnSubtract_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn7.Font = new System.Drawing.Font("굴림", 20F);
            this.Btn7.Location = new System.Drawing.Point(3, 153);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(69, 69);
            this.Btn7.TabIndex = 10;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // BtnResult
            // 
            this.BtnResult.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnResult.Font = new System.Drawing.Font("굴림", 20F);
            this.BtnResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnResult.Location = new System.Drawing.Point(0, 341);
            this.BtnResult.Name = "BtnResult";
            this.BtnResult.Size = new System.Drawing.Size(314, 60);
            this.BtnResult.TabIndex = 2;
            this.BtnResult.Text = "=";
            this.BtnResult.UseVisualStyleBackColor = false;
            this.BtnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 401);
            this.Controls.Add(this.BtnResult);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Display;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnSubtract;
        private System.Windows.Forms.Button BtnPoint;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnAllClear;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button BtnMultiply;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button BtnDivide;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button BtnResult;
    }
}

