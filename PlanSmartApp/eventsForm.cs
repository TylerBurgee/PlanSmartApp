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
        public eventsForm()
        {
            InitializeComponent();
        }
        
        /* Get data from createEventForm, add data to list of events, and send data to Events to be saved into database */
        public void setEvent(string event_name, string event_time, string event_location)
        {
            events_ListBox.Items.Add(event_name + ", time: " + event_time + ", location: " + event_location);

            Event.createEvent(event_name, event_time, event_location);
        }

        /* Create form for getting user input */
        private void createEvent_Button_Click(object sender, EventArgs e)
        {
            var createEventForm = new createEventForm(this);
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
    }
}
