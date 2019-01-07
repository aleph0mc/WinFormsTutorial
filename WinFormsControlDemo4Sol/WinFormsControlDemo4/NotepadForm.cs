using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsControlDemo4
{
    public partial class NotepadForm : Form
    {
        private string _FileName;
        private bool _Modified = false;
        private FindDialog _dlgFind;

        public NotepadForm()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNotes.Text = string.Empty;
            _FileName = string.Empty;
            _Modified = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _FileName = dlg.FileName;

                using (var sr = new StreamReader(_FileName))
                    txtNotes.Text = sr.ReadToEnd();

                _Modified = false;

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_FileName))
            {
                var dlg = new SaveFileDialog();
                dlg.Filter = "Documents (*.txt)|*.txt|All Files (*.*)|*.*";

                if (dlg.ShowDialog() == DialogResult.OK)
                    _FileName = dlg.FileName;
                else // cancel is clicked
                    return;
            }
            using (var sw = new StreamWriter(_FileName))
                sw.Write(txtNotes.Text);

            _Modified = false;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _FileName = string.Empty;
            saveToolStripMenuItem_Click(sender, e);
            _Modified = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {
            _Modified = true;
        }

        private void NotepadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_Modified)
            {
                var dr = MessageBox.Show($"Do you want to save changes to {_FileName ?? "Untitled"}?",
                    "Save", MessageBoxButtons.YesNoCancel);

                if (dr == DialogResult.Yes)
                    saveToolStripMenuItem_Click(sender, EventArgs.Empty);
                else if (dr == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new FontDialog();
            dlg.Font = txtNotes.Font;
            if (dlg.ShowDialog() == DialogResult.OK)
                txtNotes.Font = dlg.Font;
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // modeless dialog
            if (_dlgFind == null)
            {
                _dlgFind = new FindDialog();
                _dlgFind.Show(this); // current form is the owner
                // alternatively
                //_dlgFind.Owner = this;
                //_dlgFind.Show();
                // close event for FindDialog
                // next time the dialog will have a new instance
                _dlgFind.FormClosed += (sdr, evt) => _dlgFind = null;
            }
            else // simply activate the dialog avoiding to create multiple instances
                _dlgFind.Activate();
        }
    }
}
