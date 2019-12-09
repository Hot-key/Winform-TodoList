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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelTodoItemScroll = new System.Windows.Forms.Panel();
            this.panelInputData = new System.Windows.Forms.Panel();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonInput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTodoItem = new System.Windows.Forms.Panel();
            this.panelTitle.SuspendLayout();
            this.panelTodoItemScroll.SuspendLayout();
            this.panelInputData.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(169)))), ((int)(((byte)(241)))));
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(500, 65);
            this.panelTitle.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(179, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(142, 45);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Todo List";
            // 
            // panelTodoItemScroll
            // 
            this.panelTodoItemScroll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTodoItemScroll.AutoScroll = true;
            this.panelTodoItemScroll.AutoScrollMargin = new System.Drawing.Size(0, 32);
            this.panelTodoItemScroll.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTodoItemScroll.Controls.Add(this.panelTodoItem);
            this.panelTodoItemScroll.Location = new System.Drawing.Point(0, -17);
            this.panelTodoItemScroll.Name = "panelTodoItemScroll";
            this.panelTodoItemScroll.Size = new System.Drawing.Size(510, 654);
            this.panelTodoItemScroll.TabIndex = 5;
            // 
            // panelInputData
            // 
            this.panelInputData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(239)))), ((int)(((byte)(253)))));
            this.panelInputData.Controls.Add(this.label2);
            this.panelInputData.Controls.Add(this.label1);
            this.panelInputData.Controls.Add(this.buttonInput);
            this.panelInputData.Controls.Add(this.textBoxInput);
            this.panelInputData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInputData.Location = new System.Drawing.Point(0, 620);
            this.panelInputData.Margin = new System.Windows.Forms.Padding(30, 3, 5, 3);
            this.panelInputData.Name = "panelInputData";
            this.panelInputData.Size = new System.Drawing.Size(500, 55);
            this.panelInputData.TabIndex = 0;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(239)))), ((int)(((byte)(253)))));
            this.textBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.Location = new System.Drawing.Point(30, 16);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(20, 3, 5, 3);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(351, 22);
            this.textBoxInput.TabIndex = 0;
            // 
            // buttonInput
            // 
            this.buttonInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(169)))), ((int)(((byte)(241)))));
            this.buttonInput.FlatAppearance.BorderSize = 0;
            this.buttonInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInput.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInput.ForeColor = System.Drawing.Color.White;
            this.buttonInput.Location = new System.Drawing.Point(395, 15);
            this.buttonInput.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(75, 27);
            this.buttonInput.TabIndex = 1;
            this.buttonInput.Text = "추가";
            this.buttonInput.UseVisualStyleBackColor = false;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 2);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 2);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(500, 3);
            this.label3.TabIndex = 4;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.panelInputData);
            this.panelMain.Controls.Add(this.panelTodoItemScroll);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 65);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(500, 675);
            this.panelMain.TabIndex = 0;
            // 
            // panelTodoItem
            // 
            this.panelTodoItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTodoItem.AutoSize = true;
            this.panelTodoItem.Location = new System.Drawing.Point(0, 17);
            this.panelTodoItem.Name = "panelTodoItem";
            this.panelTodoItem.Size = new System.Drawing.Size(493, 606);
            this.panelTodoItem.TabIndex = 0;
            this.panelTodoItem.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTodoItem_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 740);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTitle);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelTodoItemScroll.ResumeLayout(false);
            this.panelTodoItemScroll.PerformLayout();
            this.panelInputData.ResumeLayout(false);
            this.panelInputData.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelTodoItemScroll;
        private System.Windows.Forms.Panel panelInputData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTodoItem;
    }
}

