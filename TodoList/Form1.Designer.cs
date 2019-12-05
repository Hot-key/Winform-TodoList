namespace TodoList
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelInputData = new System.Windows.Forms.Panel();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.buttonInput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelInputData.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.panelInputData);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 80);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(550, 660);
            this.panelMain.TabIndex = 0;
            // 
            // panelInputData
            // 
            this.panelInputData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(239)))), ((int)(((byte)(253)))));
            this.panelInputData.Controls.Add(this.label2);
            this.panelInputData.Controls.Add(this.label1);
            this.panelInputData.Controls.Add(this.buttonInput);
            this.panelInputData.Controls.Add(this.textBoxInput);
            this.panelInputData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInputData.Location = new System.Drawing.Point(0, 575);
            this.panelInputData.Margin = new System.Windows.Forms.Padding(30, 3, 5, 3);
            this.panelInputData.Name = "panelInputData";
            this.panelInputData.Size = new System.Drawing.Size(550, 85);
            this.panelInputData.TabIndex = 0;
            // 
            // textBoxInput
            // 
            this.textBoxInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(239)))), ((int)(((byte)(253)))));
            this.textBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.Location = new System.Drawing.Point(39, 31);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(30, 3, 5, 3);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(401, 22);
            this.textBoxInput.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(169)))), ((int)(((byte)(241)))));
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(550, 80);
            this.panelTitle.TabIndex = 1;
            // 
            // buttonInput
            // 
            this.buttonInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(169)))), ((int)(((byte)(241)))));
            this.buttonInput.FlatAppearance.BorderSize = 0;
            this.buttonInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInput.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInput.ForeColor = System.Drawing.Color.White;
            this.buttonInput.Location = new System.Drawing.Point(448, 30);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(75, 27);
            this.buttonInput.TabIndex = 1;
            this.buttonInput.Text = "추가";
            this.buttonInput.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(37, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 2);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(550, 2);
            this.label2.TabIndex = 3;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(194, 17);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(163, 47);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Todo List";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(550, 3);
            this.label3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 740);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMain.ResumeLayout(false);
            this.panelInputData.ResumeLayout(false);
            this.panelInputData.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelInputData;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Label labelTitle;
    }
}

