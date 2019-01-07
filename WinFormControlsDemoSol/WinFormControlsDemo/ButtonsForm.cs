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
    public partial class ButtonsForm : Form
    {
        public ButtonsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form property AcceptButton (default button)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save");
        }

        /// <summary>
        /// For this button the CausesValidation property is set to False
        /// Form property CancelButton (ESC key)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Cancelled");
            // if the textbox is not valid (value > 100) the form won't close
            // workaroud is set a valid value
            // this is anyway not enough went the form close icon (X) is pressed
            insertValidDummyData();
            //textBox1.Text = "1";
            this.Close();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            var n = int.Parse(textBox1.Text);
            if (n > 100)
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "Value must < 100");
            }
            else
                errorProvider1.SetError(textBox1, "");
        }

        private void ButtonsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // value set to a valid value
            insertValidDummyData();
            //textBox1.Text = "1";
            e.Cancel = false;
        }

        // better create a method for we might have more valid values
        private void insertValidDummyData()
        {
            textBox1.Text = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (checkBox1.CheckState)
            {
                case CheckState.Unchecked:
                    break;
                case CheckState.Checked:
                    break;
                case CheckState.Indeterminate:
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text + " " + comboBox1.SelectedItem?.ToString());

        }

        private void ButtonsForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                var s = new Student
                {
                    ID = i,
                    Name = "S" + i.ToString()
                };

                comboBox4.Items.Add(s);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var s = comboBox4.SelectedItem as Student;
            MessageBox.Show(s.ID + " " + s.Name);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = comboBox4.SelectedItem as Student;
            MessageBox.Show(s.ID + " " + s.Name);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dpForm = new DatePickerForm();
            dpForm.FormClosed += (s, args) => this.Close();
            dpForm.Show();
        }
    }

    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
