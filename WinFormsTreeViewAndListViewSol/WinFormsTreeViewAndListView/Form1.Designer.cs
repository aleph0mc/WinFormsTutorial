namespace WinFormsTreeViewAndListView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Departments", 1, 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvCompDept = new System.Windows.Forms.TreeView();
            this.lvCompEmp = new System.Windows.Forms.ListView();
            this.imgDepts = new System.Windows.Forms.ImageList(this.components);
            this.imgDeptsLarge = new System.Windows.Forms.ImageList(this.components);
            this.cmnsViewOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnsLargeIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnsSmallIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnsList = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnsDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.colEmpId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmpName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmpDept = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.cmnsViewOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvCompDept);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvCompEmp);
            this.splitContainer1.Size = new System.Drawing.Size(598, 476);
            this.splitContainer1.SplitterDistance = 199;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvCompDept
            // 
            this.tvCompDept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvCompDept.ImageIndex = 0;
            this.tvCompDept.ImageList = this.imgDepts;
            this.tvCompDept.Location = new System.Drawing.Point(0, 0);
            this.tvCompDept.Name = "tvCompDept";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "tnDepartments";
            treeNode1.SelectedImageIndex = 0;
            treeNode1.Text = "Departments";
            this.tvCompDept.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvCompDept.SelectedImageIndex = 0;
            this.tvCompDept.Size = new System.Drawing.Size(199, 476);
            this.tvCompDept.TabIndex = 0;
            this.tvCompDept.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvCompDept_AfterSelect);
            // 
            // lvCompEmp
            // 
            this.lvCompEmp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEmpId,
            this.colEmpName,
            this.colEmpDept});
            this.lvCompEmp.ContextMenuStrip = this.cmnsViewOptions;
            this.lvCompEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCompEmp.FullRowSelect = true;
            this.lvCompEmp.LargeImageList = this.imgDeptsLarge;
            this.lvCompEmp.Location = new System.Drawing.Point(0, 0);
            this.lvCompEmp.Name = "lvCompEmp";
            this.lvCompEmp.Size = new System.Drawing.Size(395, 476);
            this.lvCompEmp.SmallImageList = this.imgDepts;
            this.lvCompEmp.TabIndex = 0;
            this.lvCompEmp.UseCompatibleStateImageBehavior = false;
            this.lvCompEmp.View = System.Windows.Forms.View.Details;
            // 
            // imgDepts
            // 
            this.imgDepts.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgDepts.ImageStream")));
            this.imgDepts.TransparentColor = System.Drawing.Color.Transparent;
            this.imgDepts.Images.SetKeyName(0, "think_emoj_small.jpg");
            this.imgDepts.Images.SetKeyName(1, "ic_launcher.png");
            // 
            // imgDeptsLarge
            // 
            this.imgDeptsLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgDeptsLarge.ImageStream")));
            this.imgDeptsLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imgDeptsLarge.Images.SetKeyName(0, "ic_launcher.png");
            this.imgDeptsLarge.Images.SetKeyName(1, "think_emoj_small.jpg");
            // 
            // cmnsViewOptions
            // 
            this.cmnsViewOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnsLargeIcons,
            this.cmnsSmallIcons,
            this.cmnsList,
            this.cmnsDetails});
            this.cmnsViewOptions.Name = "cmnsViewOptions";
            this.cmnsViewOptions.Size = new System.Drawing.Size(135, 92);
            // 
            // cmnsLargeIcons
            // 
            this.cmnsLargeIcons.Name = "cmnsLargeIcons";
            this.cmnsLargeIcons.Size = new System.Drawing.Size(134, 22);
            this.cmnsLargeIcons.Text = "Large Icons";
            this.cmnsLargeIcons.Click += new System.EventHandler(this.cmnsLargeIcons_Click);
            // 
            // cmnsSmallIcons
            // 
            this.cmnsSmallIcons.Name = "cmnsSmallIcons";
            this.cmnsSmallIcons.Size = new System.Drawing.Size(134, 22);
            this.cmnsSmallIcons.Text = "Small Icons";
            this.cmnsSmallIcons.Click += new System.EventHandler(this.cmnsSmallIcons_Click);
            // 
            // cmnsList
            // 
            this.cmnsList.Name = "cmnsList";
            this.cmnsList.Size = new System.Drawing.Size(134, 22);
            this.cmnsList.Text = "List";
            this.cmnsList.Click += new System.EventHandler(this.cmnsList_Click);
            // 
            // cmnsDetails
            // 
            this.cmnsDetails.Name = "cmnsDetails";
            this.cmnsDetails.Size = new System.Drawing.Size(134, 22);
            this.cmnsDetails.Text = "Details";
            this.cmnsDetails.Click += new System.EventHandler(this.cmnsDetails_Click);
            // 
            // colEmpId
            // 
            this.colEmpId.Text = "Emp ID";
            this.colEmpId.Width = 98;
            // 
            // colEmpName
            // 
            this.colEmpName.Text = "Emp Name";
            this.colEmpName.Width = 149;
            // 
            // colEmpDept
            // 
            this.colEmpDept.Text = "Emp Dept";
            this.colEmpDept.Width = 92;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 476);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.cmnsViewOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvCompDept;
        private System.Windows.Forms.ListView lvCompEmp;
        private System.Windows.Forms.ImageList imgDepts;
        private System.Windows.Forms.ImageList imgDeptsLarge;
        private System.Windows.Forms.ContextMenuStrip cmnsViewOptions;
        private System.Windows.Forms.ToolStripMenuItem cmnsLargeIcons;
        private System.Windows.Forms.ToolStripMenuItem cmnsSmallIcons;
        private System.Windows.Forms.ToolStripMenuItem cmnsList;
        private System.Windows.Forms.ToolStripMenuItem cmnsDetails;
        private System.Windows.Forms.ColumnHeader colEmpId;
        private System.Windows.Forms.ColumnHeader colEmpName;
        private System.Windows.Forms.ColumnHeader colEmpDept;
    }
}

