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

namespace WinFormsComponents
{
    public partial class DragAndDropForm : Form
    {
        public DragAndDropForm()
        {
            InitializeComponent();
        }

        private void lstDocs_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void lstDocs_DragDrop(object sender, DragEventArgs e)
        {
            if (lstDocs.Items.Count != 0)
            {
                lstDocs.Items.Clear();
            }
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
                lstDocs.Items.Add(Path.GetFileName(s[i]));
        }
    }
}
