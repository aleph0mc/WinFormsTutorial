using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDragAndDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var filename in files)
            {
                listBox1.Items.Add(filename);
            }
        }

        // drag start
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(panel1.BackgroundImage, DragDropEffects.Copy);
        }

        private void panel2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        // drop
        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
            panel2.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            // OR
            //panel2.BackgroundImage = (Bitmap)e.Data.GetData(typeof(Bitmap));
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox1.Items.Count > 0)
                DoDragDrop(listBox1.SelectedItem, DragDropEffects.Move);
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            textBox1.Text = (string)e.Data.GetData(DataFormats.StringFormat);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            listBox1.SelectedIndex = -1;
        }
    }
}
