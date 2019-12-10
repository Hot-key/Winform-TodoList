using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoList.Controls
{
    public class TodoItem : UserControl
    {
        private int zIndex = 0;

        private bool isMouseEnter = false;

        private Timer timer1 = new Timer();

        private Font font = new Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point, ((byte) (0)));

        private bool checked_ = false;

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

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isMouseEnter)
            {
                if (zIndex < 5)
                {
                    this.Location = new Point(this.Location.X - 1, this.Location.Y - 1);
                    zIndex++;
                }
            }
            else
            {
                if (zIndex > 0)
                {
                    this.Location = new Point(this.Location.X + 1, this.Location.Y + 1);
                    zIndex--;
                }
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            isMouseEnter = true;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            isMouseEnter = false;
            base.OnMouseLeave(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            timer1.Interval = 25;
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;

            base.OnLoad(e);
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            float sizeInPoints = this.Font.SizeInPoints / 72 * e.Graphics.DpiX;

            var rc = new Rectangle(new Point(Height / 6, Height / 4), new Size(Height / 2, Height / 2));

            ControlPaint.DrawCheckBox(g, rc,
                this.checked_ ? ButtonState.Flat | ButtonState.Checked : ButtonState.Flat | ButtonState.Normal);

            g.DrawString(this.Text, this.Font, Brushes.Black, rc.Width + rc.X * 2, (Height - sizeInPoints) / 2 - 5);

            base.OnPaint(e);
        }
            
        protected override void OnClick(EventArgs e)
        {
            checked_ = !checked_;
            this.Refresh();

            base.OnClick(e);
        }

        protected override void Dispose(bool disposing)
        {
            timer1.Dispose();

            base.Dispose(disposing);
        }
    }
}