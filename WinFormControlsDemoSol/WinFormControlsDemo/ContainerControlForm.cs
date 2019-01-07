using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormControlsDemo
{
    public partial class ContainerControlForm : Form
    {
        public ContainerControlForm()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add("New Tab");
            var tp = new TabPage();
            tp.Text = "New Tab 2";
            tabControl1.TabPages.Add(tp);

            var btn = new Button();
            btn.Text = "Dynamic";
            tp.Controls.Add(btn);
            tp.BackColor = Color.Red;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new SplitContainerForm();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }
    }
}
