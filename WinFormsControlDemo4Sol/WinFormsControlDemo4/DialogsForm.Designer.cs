namespace WinFormsControlDemo4
{
    partial class DialogsForm
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
            this.btnPosition = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnNotepad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPosition
            // 
            this.btnPosition.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPosition.Location = new System.Drawing.Point(0, 0);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(369, 23);
            this.btnPosition.TabIndex = 0;
            this.btnPosition.Text = "Set Start Position";
            this.btnPosition.UseVisualStyleBackColor = true;
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // btnColor
            // 
            this.btnColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnColor.Location = new System.Drawing.Point(0, 23);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(369, 23);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Set Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnNotepad
            // 
            this.btnNotepad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotepad.Location = new System.Drawing.Point(223, 243);
            this.btnNotepad.Name = "btnNotepad";
            this.btnNotepad.Size = new System.Drawing.Size(119, 23);
            this.btnNotepad.TabIndex = 2;
            this.btnNotepad.Text = "Notepad Form";
            this.btnNotepad.UseVisualStyleBackColor = true;
            this.btnNotepad.Click += new System.EventHandler(this.btnNotepad_Click);
            // 
            // DialogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 278);
            this.Controls.Add(this.btnNotepad);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnPosition);
            this.Name = "DialogsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DialogsForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnNotepad;
    }
}

