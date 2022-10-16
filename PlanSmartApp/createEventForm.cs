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

        public createEventForm(eventsForm ef)
        {
            InitializeComponent();
            eventsForm = ef;
        }

        /* Gets user input and sends it to eventsForm for processing */
        private void submit_Button_Click(object sender, EventArgs e)
        {
            string event_name = name_TextBox.Text;
            string event_time = time_TextBox.Text;
            string event_location = location_TextBox.Text;

            eventsForm.setEvent(event_name, event_time, event_location);
            this.Hide();
        }
    }
}
