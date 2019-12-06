using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoList.Controls;

namespace TodoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //https://stackoverflow.com/questions/2463519/drop-shadow-in-winforms-controls
            Panel panel = (Panel)sender;
            Color[] shadow = new Color[4];
            shadow[0] = Color.FromArgb(181, 181, 181);
            shadow[1] = Color.FromArgb(195, 195, 195);
            shadow[2] = Color.FromArgb(211, 211, 211);

            //245, 245, 245
            Pen pen = new Pen(shadow[0]);
            using (pen)
            {
                foreach (TodoItem item in panel.Controls.OfType<TodoItem>())
                {
                    Point pt = item.Location;
                    pt.Y += item.Height;
                    for (var sp = 0; sp < shadow.Length; sp++)
                    {
                        pen.Color = shadow[sp];
                        e.Graphics.DrawLine(pen, pt.X + sp, pt.Y + sp, pt.X + item.Width + sp, pt.Y + sp);

                        e.Graphics.DrawLine(pen, pt.X + item.Width + sp, pt.Y - item.Height + sp, pt.X + item.Width + sp, pt.Y + sp);
                    }
                }
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            panel1.Refresh();
        }
    }
}
