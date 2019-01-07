using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WniFormControlDemo2
{
    public partial class InteractiveDrawingForm : Form
    {
        //Point p1, p2;
        private List<Line> _lines = new List<Line>();
        private Line _line;

        [Serializable]
        private struct Line
        {
            public Point p1, p2;
        }

        public InteractiveDrawingForm()
        {
            InitializeComponent();
        }

        private void InteractiveDrawingForm_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            foreach (var ln in _lines)
            {
                g.DrawLine(Pens.Red, ln.p1, ln.p2);
            }
        }

        private void InteractiveDrawingForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _line.p1 = e.Location;
            }
        }

        private void InteractiveDrawingForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _line.p2 = e.Location;
                _lines.Add(_line);
                //this.Invalidate();
                var g = this.CreateGraphics();
                g.DrawLine(Pens.Blue, _line.p1, _line.p2);
                g.Dispose();
            }
        }

        void InteractiveDrawingForm_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var bf = new BinaryFormatter();
            using (var fs = new FileStream(@"c:\temp\lines.dat", FileMode.Create))
                bf.Serialize(fs, _lines);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"c:\temp\lines.dat"))
            {
                var bf = new BinaryFormatter();
                using (var fs = new FileStream(@"c:\temp\lines.dat", FileMode.Open))
                    _lines = (List<Line>)bf.Deserialize(fs);
                this.Invalidate();
            }
        }

        private void btnCreateImg_Click(object sender, EventArgs e)
        {
            using (var bmp = new Bitmap(800, 500))
            {
                var g = Graphics.FromImage(bmp);
                // white background
                g.FillRectangle(Brushes.White, 0, 0, bmp.Width, bmp.Height);
                // draw on the bitmap
                foreach (var ln in _lines)
                {
                    g.DrawLine(Pens.Red, ln.p1, ln.p2);
                }
                // save as JPEG
                bmp.Save(@"c:\temp\bmpDemo.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
    }
}
