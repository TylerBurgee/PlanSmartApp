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
    public partial class eventsForm : Form
    {
        private string date;
        public eventsForm(string date)
        {
            InitializeComponent();
            this.date = date;
            date_Label.Text = date;
        }
        
        /* Get data from createEventForm, add data to list of events, and send data to Events to be saved into database */
        public void setEvent()
        {
            string username = loginForm.username;
            var user_events = Event.getEvents(date, username);

            events_ListBox.Items.Clear();

            foreach (string line in user_events)
            {
                var splitLine = line.Split(',');
                events_ListBox.Items.Add(splitLine[0] + ", date: " + splitLine[1] + ", time: " + splitLine[2] + ", location: " + splitLine[3]);
            }
            
            //events_ListBox.Items.Add(event_name + ", time: " + event_time + ", location: " + event_location);
        }

        /* Create form for getting user input */
        private void createEvent_Button_Click(object sender, EventArgs e)
        {
            var createEventForm = new createEventForm(this, this.date);
            createEventForm.Show();
        }

        /* Get selected event, send data to Events to be modified */
        private void modifyEvent_Button_Click(object sender, EventArgs e)
        {

        }

        /* Get selected event, send data to Events to be deleted */
        private void deleteEvent_Button_Click(object sender, EventArgs e)
        {

        }

        /* Get selected event, send email with event details */
        private void createInvite_Button_Click(object sender, EventArgs e)
        {
            var emailForm = new emailForm();
            emailForm.Show();
        }
    }
}
