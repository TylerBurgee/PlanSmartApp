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
    public partial class modifyEventForm : Form
    {
        eventsForm eventsForm;
        private string selectedEvent;
        private string date;
        public modifyEventForm(eventsForm ef, string date, string selectedEvent)
        {
            eventsForm = ef;
            this.date = date;
            InitializeComponent();
            this.selectedEvent = selectedEvent;
            var eventArray = selectedEvent.Split(",");
            name_TextBox.Text = eventArray[0];
            time_TextBox.Text = eventArray[2];
            location_TextBox.Text = eventArray[3];
        }

        private void submit_Button_Click(object sender, EventArgs e)
        {
            string event_name = name_TextBox.Text;
            string event_time = time_TextBox.Text;
            string event_location = location_TextBox.Text;

            FileIO.removeFromFile("events.txt", this.selectedEvent + "," + loginForm.username);
            Event.createEvent(event_name, this.date, event_time, event_location, loginForm.username);
            eventsForm.setEvent();
            this.Hide();
        }
    }
}
