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
    public partial class FindDialog : Form
    {
        private int _start = -1;
        public FindDialog()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            var frmNotepad = this.Owner as NotepadForm;
            // the property Modifiers of the control must be set to public
            var txt = frmNotepad.txtNotes;
            _start = txt.Text.IndexOf(txtFind.Text, _start + 1);
            if (-1 == _start)
            {
                MessageBox.Show("End of string.");
                return;
            }
            txt.Select(_start, txtFind.Text.Length);
            frmNotepad.Activate();
        }
    }
}
