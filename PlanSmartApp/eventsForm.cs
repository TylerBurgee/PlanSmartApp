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
                events_ListBox.Items.Add(splitLine[0] + "," + splitLine[1] + "," + splitLine[2] + "," + splitLine[3]);
            }
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
            string selectedEvent = events_ListBox.GetItemText(events_ListBox.SelectedItem);
            var modifyEventForm = new modifyEventForm(this, this.date, selectedEvent);

            modifyEventForm.Show();
        }

        /* Get selected event, send data to Events to be deleted */
        private void deleteEvent_Button_Click(object sender, EventArgs e)
        {
            string selectedEvent = events_ListBox.GetItemText(events_ListBox.SelectedItem);
            FileIO.removeFromFile("events.txt", selectedEvent + "," + loginForm.username);
            setEvent();
        }

        /* Get selected event, send email with event details */
        private void createInvite_Button_Click(object sender, EventArgs e)
        {
            string selected_event = events_ListBox.GetItemText(events_ListBox.SelectedItem);
            var emailForm = new emailForm(selected_event);
            emailForm.Show();
        }
    }
}
