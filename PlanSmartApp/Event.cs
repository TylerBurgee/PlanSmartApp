using System;
using System.Globalization;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

public class Event

{
    private string name;
    private string time;
    private string location;

    public Event(string name, string time, string location)
	{   
        this.name = name;
        this.time = time;
        this.location = location;
	}

	public void createEvent()
	{
        // Create dictionary with event details
        Dictionary<string, string> new_event = new Dictionary<string, string>();
        new_event.Add("name", name);
        new_event.Add("time", time);
        new_event.Add("location", location);

        // Save dictionart to events database

    }

    public void deleteEvent(string event_id)
    {
        // Get file contents

        // Loop through file contents, find given event_id

        // Remove contents from events database

    }

    public void modifyEvent(string event_id)
    {

        // Get file contents

        // Loop through file contents, find given event_id

        // Modify contents of events database

    }

}