﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLoginFacility
{
    public partial class LoginDialog : Form
    {
        public LoginDialog()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var usr = txtUsername.Text;
            var pwd = txtPassword.Text;

            if (usr == pwd)
                this.DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Invalid username or password.");

        }
    }
}
