using System;
using System.Drawing;
using System.Windows.Forms;

namespace Курсова_Робота
{
    public class BaseForm : Form
    {
        protected Point lastPoint; 

        protected void HandleMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        protected void HandleMouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}