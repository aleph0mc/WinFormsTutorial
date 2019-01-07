namespace WinFormsComponents
{
    partial class DragAndDropForm
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
            this.lstDocs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstDocs
            // 
            this.lstDocs.AllowDrop = true;
            this.lstDocs.FormattingEnabled = true;
            this.lstDocs.Location = new System.Drawing.Point(50, 44);
            this.lstDocs.Name = "lstDocs";
            this.lstDocs.Size = new System.Drawing.Size(256, 212);
            this.lstDocs.TabIndex = 0;
            this.lstDocs.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstDocs_DragDrop);
            this.lstDocs.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstDocs_DragEnter);
            // 
            // DragAndDropForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstDocs);
            this.Name = "DragAndDropForm";
            this.Text = "DragAndDropForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDocs;
    }
}