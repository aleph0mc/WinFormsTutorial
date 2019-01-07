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
    public partial class PositionDialog : Form
    {
        public new int Left
        {
            get
            {
                return int.Parse(txtX.Text);
            }
            set
            {
                txtX.Text = value.ToString();
            }
        }
        public new int Top
        {
            get
            {
                return int.Parse(txtY.Text);
            }
            set
            {
                txtY.Text = value.ToString();
            }
        }

        public PositionDialog()
        {
            InitializeComponent();
        }

        private void PositionDialog_KeyPress(object sender, KeyPressEventArgs e)
        {
            var backspace = 8;

            if (e.KeyChar == backspace)
                return;
            if (e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.Empty == txtX.Text.Trim() || string.Empty == txtY.Text.Trim())
                MessageBox.Show("Please enter all values");
            else
                this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
