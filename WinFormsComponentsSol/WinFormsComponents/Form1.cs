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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSysTime.Text = DateTime.Now.ToLongTimeString();

        }

        private void rbnEnabled_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void rbnDisabled_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnShowSysTime_Click(object sender, EventArgs e)
        {
            // start a new a background thread
            backgroundWorker1.RunWorkerAsync();
        }

        int perc;
        int n;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // background thread
            while (true)
            {
                lblBwSysTime.Text = DateTime.Now.ToLongTimeString();
                System.Threading.Thread.Sleep(1000);
                Application.DoEvents();
                if (2 == n)
                {
                    perc += 10;
                    backgroundWorker1.ReportProgress(perc);
                    n = 0;
                }
                ++n;
                if (100 == perc || backgroundWorker1.CancellationPending)
                    break;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbTimer.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Task Completed");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void fsWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            RefreshList();
        }

        private void fsWatcher_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            RefreshList();
        }

        private void fsWatcher_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            RefreshList();
        }

        private void fsWatcher_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            var dInfo = new DirectoryInfo(@"C:\Projects\WindowsFormsTutorial\WinFormsComponentsSol\WinFormsComponents\FileSysWatcherFolder");
            lsbFiles.Items.Clear();
            foreach (var fInfo in dInfo.GetFiles())
                lsbFiles.Items.Add(fInfo.Name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnStartNotepad_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                procNotepad.StartInfo.Arguments = dlg.FileName;
                procNotepad.StartInfo.FileName = "Notepad.exe";
                procNotepad.Start();

            }
        }
    }
}
