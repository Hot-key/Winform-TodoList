using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        private void panelTodoItem_Paint(object sender, PaintEventArgs e)
        {
            //https://stackoverflow.com/questions/2463519/drop-shadow-in-winforms-controls
            Color[] shadow = new Color[4];
            shadow[0] = Color.FromArgb(181, 181, 181);
            shadow[1] = Color.FromArgb(195, 195, 195);
            shadow[2] = Color.FromArgb(211, 211, 211);

            using (Pen pen = new Pen(shadow[0]))
            {
                foreach (TodoItem item in panelTodoItem.Controls.OfType<TodoItem>())
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
            panelTodoItem.Refresh();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            TodoItem todoItem = new TodoItem();

            todoItem.Location = new Point(15, ((panelTodoItem.Controls.Count) * 91) + 16 + 17);
            todoItem.Size = new Size(panelTodoItem.Width - 30 - 20, 75);
            todoItem.Text = textBoxInput.Text;
            panelTodoItem.Controls.Add(todoItem);

            panelTodoItem.Refresh();
            textBoxInput.Clear();
        }
    }
}
