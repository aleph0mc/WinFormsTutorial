namespace WinFormsComponents
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSysTime = new System.Windows.Forms.Label();
            this.rbnEnabled = new System.Windows.Forms.RadioButton();
            this.rbnDisabled = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnShowSysTime = new System.Windows.Forms.Button();
            this.lblBwSysTime = new System.Windows.Forms.Label();
            this.pbTimer = new System.Windows.Forms.ProgressBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.fsWatcher = new System.IO.FileSystemWatcher();
            this.lsbFiles = new System.Windows.Forms.ListBox();
            this.procNotepad = new System.Diagnostics.Process();
            this.btnStartNotepad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fsWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSysTime
            // 
            this.lblSysTime.AutoSize = true;
            this.lblSysTime.Location = new System.Drawing.Point(345, 20);
            this.lblSysTime.Name = "lblSysTime";
            this.lblSysTime.Size = new System.Drawing.Size(30, 13);
            this.lblSysTime.TabIndex = 0;
            this.lblSysTime.Text = "Time";
            // 
            // rbnEnabled
            // 
            this.rbnEnabled.AutoSize = true;
            this.rbnEnabled.Location = new System.Drawing.Point(348, 45);
            this.rbnEnabled.Name = "rbnEnabled";
            this.rbnEnabled.Size = new System.Drawing.Size(64, 17);
            this.rbnEnabled.TabIndex = 1;
            this.rbnEnabled.Text = "Enabled";
            this.rbnEnabled.UseVisualStyleBackColor = true;
            this.rbnEnabled.CheckedChanged += new System.EventHandler(this.rbnEnabled_CheckedChanged);
            // 
            // rbnDisabled
            // 
            this.rbnDisabled.AutoSize = true;
            this.rbnDisabled.Checked = true;
            this.rbnDisabled.Location = new System.Drawing.Point(348, 83);
            this.rbnDisabled.Name = "rbnDisabled";
            this.rbnDisabled.Size = new System.Drawing.Size(66, 17);
            this.rbnDisabled.TabIndex = 1;
            this.rbnDisabled.TabStop = true;
            this.rbnDisabled.Text = "Disabled";
            this.rbnDisabled.UseVisualStyleBackColor = true;
            this.rbnDisabled.CheckedChanged += new System.EventHandler(this.rbnDisabled_CheckedChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnShowSysTime
            // 
            this.btnShowSysTime.Location = new System.Drawing.Point(14, 45);
            this.btnShowSysTime.Name = "btnShowSysTime";
            this.btnShowSysTime.Size = new System.Drawing.Size(75, 23);
            this.btnShowSysTime.TabIndex = 2;
            this.btnShowSysTime.Text = "Show Time";
            this.btnShowSysTime.UseVisualStyleBackColor = true;
            this.btnShowSysTime.Click += new System.EventHandler(this.btnShowSysTime_Click);
            // 
            // lblBwSysTime
            // 
            this.lblBwSysTime.AutoSize = true;
            this.lblBwSysTime.Location = new System.Drawing.Point(12, 20);
            this.lblBwSysTime.Name = "lblBwSysTime";
            this.lblBwSysTime.Size = new System.Drawing.Size(30, 13);
            this.lblBwSysTime.TabIndex = 0;
            this.lblBwSysTime.Text = "Time";
            // 
            // pbTimer
            // 
            this.pbTimer.BackColor = System.Drawing.Color.White;
            this.pbTimer.Location = new System.Drawing.Point(15, 74);
            this.pbTimer.Name = "pbTimer";
            this.pbTimer.Size = new System.Drawing.Size(297, 17);
            this.pbTimer.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbTimer.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(95, 45);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel Task";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fsWatcher
            // 
            this.fsWatcher.EnableRaisingEvents = true;
            this.fsWatcher.NotifyFilter = ((System.IO.NotifyFilters)(((System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.Size) 
            | System.IO.NotifyFilters.LastWrite)));
            this.fsWatcher.Path = "C:\\Projects\\WindowsFormsTutorial\\WinFormsComponentsSol\\WinFormsComponents\\FileSys" +
    "WatcherFolder";
            this.fsWatcher.SynchronizingObject = this;
            this.fsWatcher.Changed += new System.IO.FileSystemEventHandler(this.fsWatcher_Changed);
            this.fsWatcher.Created += new System.IO.FileSystemEventHandler(this.fsWatcher_Created);
            this.fsWatcher.Deleted += new System.IO.FileSystemEventHandler(this.fsWatcher_Deleted);
            this.fsWatcher.Renamed += new System.IO.RenamedEventHandler(this.fsWatcher_Renamed);
            // 
            // lsbFiles
            // 
            this.lsbFiles.FormattingEnabled = true;
            this.lsbFiles.Location = new System.Drawing.Point(15, 109);
            this.lsbFiles.Name = "lsbFiles";
            this.lsbFiles.Size = new System.Drawing.Size(297, 95);
            this.lsbFiles.TabIndex = 5;
            // 
            // procNotepad
            // 
            this.procNotepad.StartInfo.Domain = "";
            this.procNotepad.StartInfo.FileName = "Notepad.exe";
            this.procNotepad.StartInfo.LoadUserProfile = false;
            this.procNotepad.StartInfo.Password = null;
            this.procNotepad.StartInfo.StandardErrorEncoding = null;
            this.procNotepad.StartInfo.StandardOutputEncoding = null;
            this.procNotepad.StartInfo.UserName = "";
            this.procNotepad.SynchronizingObject = this;
            // 
            // btnStartNotepad
            // 
            this.btnStartNotepad.Location = new System.Drawing.Point(318, 109);
            this.btnStartNotepad.Name = "btnStartNotepad";
            this.btnStartNotepad.Size = new System.Drawing.Size(94, 23);
            this.btnStartNotepad.TabIndex = 6;
            this.btnStartNotepad.Text = "Notepad";
            this.btnStartNotepad.UseVisualStyleBackColor = true;
            this.btnStartNotepad.Click += new System.EventHandler(this.btnStartNotepad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 255);
            this.Controls.Add(this.btnStartNotepad);
            this.Controls.Add(this.lsbFiles);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pbTimer);
            this.Controls.Add(this.btnShowSysTime);
            this.Controls.Add(this.rbnDisabled);
            this.Controls.Add(this.rbnEnabled);
            this.Controls.Add(this.lblBwSysTime);
            this.Controls.Add(this.lblSysTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fsWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSysTime;
        private System.Windows.Forms.RadioButton rbnEnabled;
        private System.Windows.Forms.RadioButton rbnDisabled;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnShowSysTime;
        private System.Windows.Forms.Label lblBwSysTime;
        private System.Windows.Forms.ProgressBar pbTimer;
        private System.Windows.Forms.Button btnCancel;
        private System.IO.FileSystemWatcher fsWatcher;
        private System.Windows.Forms.ListBox lsbFiles;
        private System.Windows.Forms.Button btnStartNotepad;
        private System.Diagnostics.Process procNotepad;
    }
}

