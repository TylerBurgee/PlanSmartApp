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
    public partial class mainForm : Form
    {
        public string selected_date;
        private int currentMonth;
        private int currentYear;
        private DateTime date;

        List<Button> calendarButtons;

        public mainForm()
        {
            InitializeComponent();

            this.currentMonth = DateTime.Today.Month;
            this.currentYear = DateTime.Today.Year;
            this.date = new DateTime(currentYear, currentMonth, 1);

            this.calendarButtons = new List<Button>
            {
                calendar_Button0, calendar_Button1, calendar_Button2, calendar_Button3,
                calendar_Button4, calendar_Button5, calendar_Button6, calendar_Button7,
                calendar_Button8, calendar_Button9, calendar_Button10, calendar_Button11,
                calendar_Button12, calendar_Button13, calendar_Button14, calendar_Button15,
                calendar_Button16, calendar_Button17, calendar_Button18, calendar_Button19,
                calendar_Button20, calendar_Button21, calendar_Button22, calendar_Button23,
                calendar_Button24, calendar_Button25, calendar_Button26, calendar_Button27,
                calendar_Button28, calendar_Button29, calendar_Button30
            };

            loadCalendar();
        }

        private void form_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loadCalendar()
        {
            monthYear_Label.Text = date.ToString("MMMM") + " " + date.Year.ToString();

            for (int i = 0; i < calendarButtons.Count; i++)
            {
                if (currentMonth == date.AddDays(i).Month)
                {
                    // Display Day and Day of Week, respectively.
                    calendarButtons[i].Text = date.AddDays(i).Day.ToString("00");
                    calendarButtons[i].Text += "\n" + date.AddDays(i).DayOfWeek.ToString();
                }
                else { calendarButtons[i].Text = "..."; }
            }
        }

        private void calendar_Button_Click(object sender, EventArgs e)
        {
            if (!File.Exists("events.txt"))
            {
                FileIO.createFile("events.txt", "");
            }

            // Show main programForm, hide loginForm
            var button = (Button)sender;

            string username = loginForm.username;
            string day = button.Text;
            day = day.Substring(0, 2);
            selected_date = this.currentMonth + "/" + day + "/" + this.currentYear;
            var events = Event.getEvents(selected_date, username);

            var eventsForm = new eventsForm(selected_date);
            eventsForm.setEvent();
            eventsForm.Show();
        }

        private void previousMonth_Button_Click(object sender, EventArgs e)
        {
            if (currentMonth > 1)
                currentMonth --;
            else
            {
                currentMonth = 12;
                currentYear --;
            }
            date = new DateTime(currentYear, currentMonth, 1);
            loadCalendar();
        }

        private void nextMonth_Button_Click(object sender, EventArgs e)
        {
            if (currentMonth < 12) 
                currentMonth++;
            else
            {
                currentMonth = 1;
                currentYear ++;
            }
            date = new DateTime(currentYear, currentMonth, 1);
            loadCalendar();
        }
    }
}
