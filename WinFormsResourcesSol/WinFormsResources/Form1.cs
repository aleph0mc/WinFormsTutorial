using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsResources
{
    public partial class Form1 : Form
    {
        private bool _Exit;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.Icon = MyResources.sysTray;

            this.Left = WinFormsResources.Properties.Settings.Default.Left;
            this.Top = WinFormsResources.Properties.Settings.Default.Top;
            this.Width = WinFormsResources.Properties.Settings.Default.WinWidth;
            this.Height = WinFormsResources.Properties.Settings.Default.WinHeight;

            pbFile.Load("Imgs\\think.jpg");
            pbResource.Image = MyResources.ThinkImg;

            txtNotes.Text = MyResources.LoremIpsum;
        }

        private void btnMsg_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MyResources.HelloMessage);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinFormsResources.Properties.Settings.Default.Left = this.Left;
            WinFormsResources.Properties.Settings.Default.Top = this.Top;
            WinFormsResources.Properties.Settings.Default.WinWidth = this.Width;
            WinFormsResources.Properties.Settings.Default.WinHeight = this.Height;
            // save settings
            WinFormsResources.Properties.Settings.Default.Save();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_Exit)
            {
                e.Cancel = true;
                this.Visible = false;
            }

        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Exit = true;
            this.Close();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
        }
    }
}
