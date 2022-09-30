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
        public mainForm()
        {
            InitializeComponent();
        }

        private void calendar_Button_Click(object sender, EventArgs e)
        {
            List<Button> calendarButtons = new List<Button>
            { 
                calendar_Button0, calendar_Button1, calendar_Button2, calendar_Button3,
                calendar_Button4, calendar_Button5, calendar_Button6, calendar_Button7,
                calendar_Button8, calendar_Button9, calendar_Button10, calendar_Button11,
                calendar_Button12, calendar_Button13, calendar_Button14, calendar_Button15,
                calendar_Button16, calendar_Button17, calendar_Button18, calendar_Button19, 
                calendar_Button20, calendar_Button21, calendar_Button22, calendar_Button23,
                calendar_Button24, calendar_Button25, calendar_Button26, calendar_Button27,
                calendar_Button28, calendar_Button29, calendar_Button30, calendar_Button31,
                calendar_Button32, calendar_Button33, calendar_Button34
            };

            for (int i = 0; i < calendarButtons.Count; i++)
            {
                if (i ==  0)
                {
                    calendarButtons[i].Text = DateTime.Today.ToString();
                }
                else
                {
                    calendarButtons[i].Text = DateTime.Today.AddDays(i).ToString();
                }
                
            }
            //calendar_Button1.Text = DateTime.Today.ToString();
        }
    }
}
