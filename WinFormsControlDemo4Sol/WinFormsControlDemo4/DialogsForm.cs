using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsControlDemo4
{
    public partial class DialogsForm : Form
    {
        private int _X = 0;
        private int _Y = 50;
        private Color _Color = Color.Navy;

        public DialogsForm()
        {
            InitializeComponent();
        }

        private void DialogsForm_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var pen = new Pen(_Color);
            g.DrawEllipse(pen, _X, _Y, 100, 100);
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            var dlg = new PositionDialog();
            dlg.Left = _X;
            dlg.Top = _Y;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _X = dlg.Left;
                _Y = dlg.Top;

                this.Invalidate();
            }

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            var dlg = new ColorDialog();
            dlg.Color = _Color;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _Color = dlg.Color;
                this.Invalidate();
            }
        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new NotepadForm();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }
    }
}
