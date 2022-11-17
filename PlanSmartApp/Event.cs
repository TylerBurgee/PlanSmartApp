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
	public static void createEvent(string name, string date, string time, string location, string username)
	{
        // Create dictionary with event details
        string data_to_save = name + "," + date + "," + time + "," + location + "," + username;

        // Save event to database
        FileIO.appendToFile("events.txt", data_to_save);
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

    public static List<string> getEvents(string date, string username)
    {
        var file_lines = FileIO.readFile("events.txt");
        List<string> events = new List<string>();

        foreach (string line in file_lines)
        {
            if (line.Contains(date) && line.Contains(username))
            {
                events.Add(line);
            }
        }
        MessageBox.Show(events[0]);
        return events;
    }
}