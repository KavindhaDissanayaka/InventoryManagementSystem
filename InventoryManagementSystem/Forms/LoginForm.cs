﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.ToLower() == "admin" && txtPassword.Text == "1234")
            {
                MainForm myForm = new MainForm();
                myForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Credintions.");
            }
        }
    }
}
