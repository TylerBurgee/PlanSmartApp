using System;
using System.Globalization;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

public class Event

{
    private string filename;

    private string name;
    private string time;
    private string location;

    public Event(string name, string time, string location)
	{
        this.filename = "events.json";

        this.name = name;
        this.time = time;
        this.location = location;
	}

    /* Formats event to be saved into databse */
	public static void createEvent(string name, string time, string location)
	{
        // Create dictionary with event details
        Dictionary<string, string> new_event = new Dictionary<string, string>();
        new_event.Add("name", name);
        new_event.Add("time", time);
        new_event.Add("location", location);

        // Save dictionary to events database
        FileIO.write_to_file("events.json", new_event);
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