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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelInputData = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInput = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.todoItem4 = new TodoList.Controls.TodoItem();
            this.todoItem3 = new TodoList.Controls.TodoItem();
            this.todoItem2 = new TodoList.Controls.TodoItem();
            this.todoItem1 = new TodoList.Controls.TodoItem();
            this.todoItem5 = new TodoList.Controls.TodoItem();
            this.todoItem6 = new TodoList.Controls.TodoItem();
            this.todoItem7 = new TodoList.Controls.TodoItem();
            this.todoItem8 = new TodoList.Controls.TodoItem();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelInputData.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.panelInputData);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 65);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(500, 675);
            this.panelMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.todoItem8);
            this.panel1.Controls.Add(this.todoItem7);
            this.panel1.Controls.Add(this.todoItem6);
            this.panel1.Controls.Add(this.todoItem5);
            this.panel1.Controls.Add(this.todoItem4);
            this.panel1.Controls.Add(this.todoItem3);
            this.panel1.Controls.Add(this.todoItem2);
            this.panel1.Controls.Add(this.todoItem1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 616);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // panelInputData
            // 
            this.panelInputData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(239)))), ((int)(((byte)(253)))));
            this.panelInputData.Controls.Add(this.label2);
            this.panelInputData.Controls.Add(this.label1);
            this.panelInputData.Controls.Add(this.buttonInput);
            this.panelInputData.Controls.Add(this.textBoxInput);
            this.panelInputData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInputData.Location = new System.Drawing.Point(0, 616);
            this.panelInputData.Margin = new System.Windows.Forms.Padding(30, 3, 5, 3);
            this.panelInputData.Name = "panelInputData";
            this.panelInputData.Size = new System.Drawing.Size(500, 59);
            this.panelInputData.TabIndex = 0;
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 2);
            this.label1.TabIndex = 2;
            // 
            // buttonInput
            // 
            this.buttonInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(169)))), ((int)(((byte)(241)))));
            this.buttonInput.FlatAppearance.BorderSize = 0;
            this.buttonInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInput.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInput.ForeColor = System.Drawing.Color.White;
            this.buttonInput.Location = new System.Drawing.Point(395, 17);
            this.buttonInput.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(75, 27);
            this.buttonInput.TabIndex = 1;
            this.buttonInput.Text = "추가";
            this.buttonInput.UseVisualStyleBackColor = false;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(239)))), ((int)(((byte)(253)))));
            this.textBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.Location = new System.Drawing.Point(30, 18);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(20, 3, 5, 3);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(351, 22);
            this.textBoxInput.TabIndex = 0;
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
            // todoItem4
            // 
            this.todoItem4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.todoItem4.BackColor = System.Drawing.Color.White;
            this.todoItem4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoItem4.Location = new System.Drawing.Point(20, 268);
            this.todoItem4.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.todoItem4.Name = "todoItem4";
            this.todoItem4.Size = new System.Drawing.Size(443, 75);
            this.todoItem4.TabIndex = 3;
            this.todoItem4.Text = "todoItem4";
            // 
            // todoItem3
            // 
            this.todoItem3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.todoItem3.BackColor = System.Drawing.Color.White;
            this.todoItem3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoItem3.Location = new System.Drawing.Point(20, 183);
            this.todoItem3.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.todoItem3.Name = "todoItem3";
            this.todoItem3.Size = new System.Drawing.Size(443, 75);
            this.todoItem3.TabIndex = 2;
            this.todoItem3.Text = "todoItem3";
            // 
            // todoItem2
            // 
            this.todoItem2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.todoItem2.BackColor = System.Drawing.Color.White;
            this.todoItem2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoItem2.Location = new System.Drawing.Point(20, 98);
            this.todoItem2.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.todoItem2.Name = "todoItem2";
            this.todoItem2.Size = new System.Drawing.Size(443, 75);
            this.todoItem2.TabIndex = 1;
            this.todoItem2.Text = "todoItem2";
            // 
            // todoItem1
            // 
            this.todoItem1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.todoItem1.BackColor = System.Drawing.Color.White;
            this.todoItem1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoItem1.Location = new System.Drawing.Point(20, 13);
            this.todoItem1.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.todoItem1.Name = "todoItem1";
            this.todoItem1.Size = new System.Drawing.Size(443, 75);
            this.todoItem1.TabIndex = 0;
            this.todoItem1.Text = "todoItem1";
            // 
            // todoItem5
            // 
            this.todoItem5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.todoItem5.BackColor = System.Drawing.Color.White;
            this.todoItem5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoItem5.Location = new System.Drawing.Point(20, 353);
            this.todoItem5.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.todoItem5.Name = "todoItem5";
            this.todoItem5.Size = new System.Drawing.Size(443, 75);
            this.todoItem5.TabIndex = 4;
            this.todoItem5.Text = "todoItem5";
            // 
            // todoItem6
            // 
            this.todoItem6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.todoItem6.BackColor = System.Drawing.Color.White;
            this.todoItem6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoItem6.Location = new System.Drawing.Point(20, 438);
            this.todoItem6.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.todoItem6.Name = "todoItem6";
            this.todoItem6.Size = new System.Drawing.Size(443, 75);
            this.todoItem6.TabIndex = 5;
            this.todoItem6.Text = "todoItem6";
            // 
            // todoItem7
            // 
            this.todoItem7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.todoItem7.BackColor = System.Drawing.Color.White;
            this.todoItem7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoItem7.Location = new System.Drawing.Point(20, 523);
            this.todoItem7.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.todoItem7.Name = "todoItem7";
            this.todoItem7.Size = new System.Drawing.Size(443, 75);
            this.todoItem7.TabIndex = 6;
            this.todoItem7.Text = "todoItem7";
            // 
            // todoItem8
            // 
            this.todoItem8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.todoItem8.BackColor = System.Drawing.Color.White;
            this.todoItem8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoItem8.Location = new System.Drawing.Point(20, 608);
            this.todoItem8.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.todoItem8.Name = "todoItem8";
            this.todoItem8.Size = new System.Drawing.Size(443, 75);
            this.todoItem8.TabIndex = 7;
            this.todoItem8.Text = "todoItem8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 740);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.panelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private Controls.TodoItem todoItem1;
        private Controls.TodoItem todoItem2;
        private Controls.TodoItem todoItem4;
        private Controls.TodoItem todoItem3;
        private Controls.TodoItem todoItem8;
        private Controls.TodoItem todoItem7;
        private Controls.TodoItem todoItem6;
        private Controls.TodoItem todoItem5;
    }
}

