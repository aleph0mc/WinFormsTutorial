using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsControlDemo3
{
    public partial class MenusForm : Form
    {
        private enum FigureType
        {
            Rectangle,
            Ellipse
        }

        private FigureType _ft = FigureType.Rectangle;

        public MenusForm()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.TranslateTransform(0, menuStrip1.Height + toolStrip1.Height);
            switch (_ft)
            {
                case FigureType.Rectangle:
                    g.DrawRectangle(Pens.Navy, 10, 10, 200, 200);
                    break;
                case FigureType.Ellipse:
                    g.DrawEllipse(Pens.Maroon, 50, 50, 200, 250);
                    break;
                default:
                    break;
            }
        }

        private void mnuRectangle_Click(object sender, EventArgs e)
        {
            _ft = FigureType.Rectangle;
            this.Invalidate();
        }

        private void mnuEllipse_Click(object sender, EventArgs e)
        {
            _ft = FigureType.Ellipse;
            this.Invalidate();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Menu Synchonization - best practise - in the menu parent (Figure)
        private void mnuFigure_DropDownOpening(object sender, EventArgs e)
        {
            switch (_ft)
            {
                case FigureType.Rectangle:
                    mnuRectangle.Checked = true;
                    mnuEllipse.Checked = false;
                    break;
                case FigureType.Ellipse:
                    mnuRectangle.Checked = false;
                    mnuEllipse.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            switch (_ft)
            {
                case FigureType.Rectangle:
                    cmnuRectangle.Checked = true;
                    cmnuEllipse.Checked = false;
                    break;
                case FigureType.Ellipse:
                    cmnuRectangle.Checked = false;
                    cmnuEllipse.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            slblCursorPosition.Text = $"{e.Location.X}, {e.Location.Y - menuStrip1.Height - toolStrip1.Height}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new ToolStripContainerForm();
            form.FormClosed += (s, args) => this.Close();
            form.Show();

        }
    }
}
