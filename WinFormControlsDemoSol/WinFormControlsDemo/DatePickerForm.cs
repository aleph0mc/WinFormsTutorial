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
    public partial class DatePickerForm : Form
    {
        public DatePickerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // properties MinDate MaxDate
            // ShowCheckBox for null values
            // Checked to false

            if (!dateTimePicker1.Checked)
                MessageBox.Show("Null");
            else
            {
                var dt = dateTimePicker1.Value;
                MessageBox.Show(dt.ToString());
            }
        }

        private void DatePickerForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                var s = new Student
                {
                    ID = i,
                    Name = "S" + i.ToString()
                };
                listBox1.Items.Add(s);
                checkedListBox1.Items.Add(s);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                System.Threading.Thread.Sleep(10);
                progressBar1.Value += 1;
                Application.DoEvents();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new ContainerControlForm();
            form.FormClosed += (s, args) => this.Close();
            form.Show();

        }
    }
}
