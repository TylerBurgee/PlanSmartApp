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
    public partial class createEventForm : Form
    {
        eventsForm eventsForm;
        string date;
        public createEventForm(eventsForm ef, string date)
        {
            InitializeComponent();
            eventsForm = ef;
            this.date = date;
        }

        /* Gets user input and sends it to eventsForm for processing */
        private void submit_Button_Click(object sender, EventArgs e)
        {
            string event_name = name_TextBox.Text;
            string event_time = time_TextBox.Text;
            string event_location = location_TextBox.Text;

            string data_to_write = event_name + "," + this.date + "," + event_time + "," + event_location + "," + loginForm.username;

            Event.createEvent(event_name, this.date, event_time, event_location, loginForm.username);
            eventsForm.setEvent();
            this.Hide();
        }
    }
}

