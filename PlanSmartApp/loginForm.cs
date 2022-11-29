using System;
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
        public static string username = "";

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
                try
                {    
                    // No TextBoxes are empty

                    // Obtain user's inputted login credentials
                    string input_username = username_TextBox.Text;
                    string password = password_TextBox.Text;

                    // Verify login credentials
                    bool login_successful = Login.verifyCredentials(input_username, password);

                    if (login_successful)
                    {
                        username = input_username;
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
                // Most common error if attempting to login with invalid credentials as login info is retrieved via [username].json
                catch (System.IO.FileNotFoundException)
                {
                    // Show error message, reset textboxes
                    MessageBox.Show("This user does not exist. Please double-check your credentials.");
                }
            }
        }

        private void createAccount_Button_Click(object sender, EventArgs e)
        {
            var signupForm = new signupForm();
            signupForm.Show();
        }
    }
}
