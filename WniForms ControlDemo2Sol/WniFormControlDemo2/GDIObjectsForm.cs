using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WniFormControlDemo2
{
    public partial class GDIObjectsForm : Form
    {
        public GDIObjectsForm()
        {
            InitializeComponent();
        }

        private void GDIObjectsForm_Paint(object sender, PaintEventArgs e)
        {
            // gives a device context of the form
            var g = e.Graphics;
            //g.DrawRectangle(Pens.Red, 10, 10, 100, 100);
            //g.DrawEllipse(Pens.Green, 10, 10, 100, 100);

            // center of form
            var w = this.ClientSize.Width;
            var h = this.ClientSize.Height;
            var cx = w / 2;
            var cy = h / 2;
            //g.DrawRectangle(Pens.Red, cx - 50, cy - 50, 100, 100);
            //g.DrawEllipse(Pens.Green, cx - 50, cy - 50, 100, 100);
            //g.DrawLine(Pens.Red, 0, 0, w, h);
            //g.DrawLine(Pens.Red, w, 0, 0, h);
            //for (int i = 0; i < w; i += 5)
            //{
            //    g.DrawLine(Pens.Red, i, 0, w - i, h);
            //    g.DrawLine(Pens.Red, w, i, 0, h - i);
            //}

            var p = new Pen(Color.Blue);
            g.DrawRectangle(p, cx - 50, cy - 50, 100, 100);

            p = new Pen(Color.FromArgb(255, 255, 0));
            g.DrawEllipse(p, cx - 50, cy - 50, 100, 100);

            // thick = 3
            p = new Pen(Color.FromName("brown"), 3);
            g.DrawRectangle(p, cx - 100, cy - 100, 200, 200);

            p = new Pen(Color.FromKnownColor(KnownColor.ActiveBorder), 3);
            g.DrawEllipse(p, cx - 100, cy - 100, 200, 200);
            var pts = new Point[3];
            pts[0].X = w / 2;
            pts[0].Y = h / 2 - 100;
            pts[1].X = w / 2 + 100;
            pts[1].Y = h / 2 + 100;
            pts[2].X = w / 2 - 100;
            pts[2].Y = h / 2 + 100;

            //g.DrawLines(p, pts);
            g.DrawPolygon(p, pts);

            g.DrawArc(Pens.Red, 10, 10, 100, 100, 0, 90);
            g.DrawCurve(Pens.Red, pts);

            // SolidBrush, TextureBrush, LinearGradientBrush, PathGradientBrush
            //var b = new SolidBrush(Color.Red);

            var bmp = new Bitmap(@"C:\Users\Milko\Pictures\think_emoj_small.jpg");
            //var b = new TextureBrush(btm);
            //var b = new HatchBrush(HatchStyle.Cross, Color.Red, Color.Yellow);

            var b = new LinearGradientBrush(new Point(0, 0), new Point(w, h), Color.Navy, Color.Yellow);

            g.FillEllipse(b, 100, 40, 100, 100);
            g.FillPolygon(b, pts);

            // Font
            var fnt = new Font("Arial", 30, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline,
                GraphicsUnit.Point);
            g.DrawString("This is Demo", fnt, b, 250, 30);

            g.DrawImage(bmp, 100, 300);

            g.TranslateTransform(100, 100);
            g.RotateTransform(30);
            g.ScaleTransform(.5f, .5f);
            g.DrawImage(bmp, 0, 0);
            g.ResetTransform();
            g.DrawImage(bmp, 0, 0);
        }

        private void GDIObjectsForm_Resize(object sender, EventArgs e)
        {
            // repaint all the form when form size changes
            Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new InteractiveDrawingForm();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }
    }
}
