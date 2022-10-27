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
    public partial class emailForm : Form
    {
        public emailForm()
        {
            InitializeComponent();
        }

        private void sendInvite_Button_Click(object sender, EventArgs e)
        {
            string toEmail = toEmail_TextBox.Text;
            string subject = subject_TextBox.Text;
            string eventName = eventName_TextBox.Text;
            string time = time_TextBox.Text;
            string location = location_TextBox.Text;
            string message = message_TextBox.Text;

            Email email = new Email();
            email.sendMail(toEmail, subject, eventName, time, location, message);

            this.Hide();
        }
    }
}
