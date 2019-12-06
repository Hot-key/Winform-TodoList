﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoList.Controls
{
    public partial class TodoItem : UserControl
    {
        public int zIndex = 0;

        private Font font = new Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        private bool checked_ = false;

        private Point BasePoint;

        private string text;

        [
            Category("모양"),
            Description("버튼에 표시되는 문자열을 지정합니다."),
        ]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get => text;
            set => text = value;
        }

        [DefaultValue(typeof(Font), "Segoe UI, 14pt, style=Regular")]
        public new Font Font
        {
            get => font;
            set => font = value;
        }

        [DefaultValue(false)]
        public bool Checked
        {
            get => checked_;
            set => checked_ = value;
        }

        public TodoItem()
        {
            InitializeComponent();
            
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
        }

        private void TodoItem_Load(object sender, EventArgs e)
        {
            BasePoint = this.Location;
            timer1.Enabled = !DesignMode;
        }

        private void todoCheckBox1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = (Convert.ToInt32(label1.Text) + 1).ToString();

            new Task(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Interlocked.Add(ref zIndex, 1);
                    Task.Delay(30).Wait();
                }
            }).Start();
        }

        private void todoCheckBox1_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = (Convert.ToInt32(label2.Text) + 1).ToString();


            new Task(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Interlocked.Add(ref zIndex, -1);
                    Task.Delay(30).Wait();
                }
            }).Start();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            label3.Text = zIndex.ToString();
            this.Location = new Point(BasePoint.X - zIndex, BasePoint.Y - zIndex);
        }

        private void TodoItem_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            float sizeInPoints = this.Font.SizeInPoints / 72 * e.Graphics.DpiX;

            var rc = new Rectangle(new Point(Height / 6, Height / 4), new Size(Height / 2, Height / 2));

            ControlPaint.DrawCheckBox(g, rc, this.checked_ ? ButtonState.Flat | ButtonState.Checked : ButtonState.Flat | ButtonState.Normal);

            g.DrawString(this.text, this.Font, Brushes.Black, rc.Width + rc.X * 2, (Height- sizeInPoints) / 2 - 5);
        }

        private void TodoItem_Click(object sender, EventArgs e)
        {
            checked_ = !checked_;
            this.Refresh();
        }
    }
}