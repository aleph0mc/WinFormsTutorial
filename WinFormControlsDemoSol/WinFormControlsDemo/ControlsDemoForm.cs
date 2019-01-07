using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormControlsDemo
{
    public partial class ControlsDemoForm : Form
    {
        public ControlsDemoForm()
        {
            InitializeComponent();
        }

        private void ControlsDemoForm_Load(object sender, EventArgs e)
        {
            //pbImgProg.Load(@"C:\Users\Milko\Pictures\think_emoj_small.jpg");
            //pbImgProg.SizeMode = PictureBoxSizeMode.AutoSize;

            // Or (this works for Label as well)
            pbImgProg.Image = new Bitmap(@"C:\Users\Milko\Pictures\think_emoj_small.jpg");
            pbImgProg.SizeMode = PictureBoxSizeMode.AutoSize;

            // AUTOCOMPLETE - not working properly
            AutoCompleteStringCollection sc = new AutoCompleteStringCollection();
            sc.AddRange(new string[] { "One", "One Hundred", "Two", "Two Hundred" });
            textBox6.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox6.AutoCompleteCustomSource = sc;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            var p = Process.Start("http://wwwmicrosoft.com");
            p.WaitForExit();
            MessageBox.Show(p.ExitCode.ToString());
        }

        /// <summary>
        /// distinguishes the case of the key pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(((int)e.KeyChar).ToString());
            var backspace = 8;
            var dot = 46;
            if (e.KeyChar == backspace || e.KeyChar == dot)
                return;
            if (e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }

        // In case we need some key char for the form
        // then add Form_KeyPress
        // the select the property Form_KeyPreview to true
        private void ControlsDemoForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        // does not distinguish the case of the key pressed
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
                MessageBox.Show("Test!!!");
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            var num = int.Parse(textBox4.Text);
            if (num > 100)
            {
                e.Cancel = true;
                //error provider is in the component tab (toolbox)
                errorProvider1.SetError(textBox4, "Value must be < 100");
            }
            else
            {
                errorProvider1.SetError(textBox4, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var buttonsForm = new ButtonsForm();
            buttonsForm.FormClosed += (s, args) => this.Close();
            buttonsForm.Show();
        }
    }
}
