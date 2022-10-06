﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanSmartApp
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void login_Button_Click(object sender, EventArgs e)
        {
            // Check for null TextBoxes
            if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
            {
                // One or more TextBoxes are empty
                MessageBox.Show("Username and password must be entered to login!");
            }
            else
            {
                // No TextBoxes are empty

                // Obtain user's inputted login credentials
                string username = username_TextBox.Text;
                string password = password_TextBox.Text;

                // Verify login credentials
                bool login_successful = Login.verifyCredentials(username, password);

                if (login_successful)
                {
                    // Show main programForm, hide loginForm
                    var mainForm = new mainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    // Show error message, reset password textbox
                    MessageBox.Show("Login failed! Incorrect username or password.");
                    password_TextBox.Text = "";
                }
            }
        }

        private void createAccount_Button_Click(object sender, EventArgs e)
        {
            FileIO.create_file("testDatabase.json");
            Dictionary<int, string> myDict = new Dictionary<int, string>();
            myDict.Add(1, "Hello");
            FileIO.create_subdict("testDatabase.json", myDict);
            var signupForm = new signupForm();
            signupForm.Show();
        }
    }
}
