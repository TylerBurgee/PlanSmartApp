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
    public partial class signupForm : Form
    {
        public signupForm()
        {
            InitializeComponent();
        }

        private void register_Button_Click(object sender, EventArgs e)
        {
            // Obtain user's inputted info
            string firstName = firstName_TextBox.Text;
            string lastName = lastName_TextBox.Text;
            string email = email_TextBox.Text;
            string username = username_TextBox.Text;
            string password = password_TextBox.Text;

            // Check for null TextBoxes
            if(this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
            {
                // One or more TextBoxes are empty
                MessageBox.Show("All fields must be entered in order to register!");
            }
            else
            {
                // No TextBoxes are empty
                bool signup_successful = Login.signup(firstName, lastName, email, username, password);

                if (signup_successful)
                {
                    // Hide signupForm
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Unable to create a new account! Please try again later.");
                }
            }
        }
    }
}
