namespace WniFormControlDemo2
{
    partial class InteractiveDrawingForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCreateImg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(128, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save graphics";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(110, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load graphics";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCreateImg
            // 
            this.btnCreateImg.Location = new System.Drawing.Point(244, 12);
            this.btnCreateImg.Name = "btnCreateImg";
            this.btnCreateImg.Size = new System.Drawing.Size(181, 23);
            this.btnCreateImg.TabIndex = 2;
            this.btnCreateImg.Text = "Create Image";
            this.btnCreateImg.UseVisualStyleBackColor = true;
            this.btnCreateImg.Click += new System.EventHandler(this.btnCreateImg_Click);
            // 
            // InteractiveDrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateImg);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Name = "InteractiveDrawingForm";
            this.Text = "InteractiveDrawingForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.InteractiveDrawingForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InteractiveDrawingForm_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.InteractiveDrawingForm_MouseUp);
            this.Resize += new System.EventHandler(this.InteractiveDrawingForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCreateImg;
    }
}