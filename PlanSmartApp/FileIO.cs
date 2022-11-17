using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

public class FileIO
{
	public FileIO() 
	{
	}

	public static dynamic read_file(string filename)
	{
		string text = File.ReadAllText(filename);
		var file = JsonSerializer.Deserialize<Client>(text);

		string[] user_info = { file.username, file.password, file.firstName, file.lastName, file.email };

		return user_info;
    }

	/* Creates new, empty .json file */
	public static void create_file(string filename)
	{
		using (FileStream fs = File.Create(filename));
    }
	
	/* Create new dictionary within .json file */
	public static void write_to_file(string filename, Dictionary<string, string> new_subdict)
	{
        int counter = 0;
        string dataToWrite = "{";

		foreach (KeyValuePair<string, string> element in new_subdict)
		{
			if (counter == new_subdict.Count - 1)
			{
				dataToWrite = dataToWrite + "\"" + element.Key + "\":\"" + element.Value + "\"";
			}
			else
			{
                dataToWrite = dataToWrite + "\"" + element.Key + "\":\"" + element.Value + "\",";
            }
            counter++;
        }
        dataToWrite += "}";

        File.WriteAllText(filename, dataToWrite);
	}

    /* Appends content to a .txt file */
	public static void appendToFile(string filename, string content)
	{
        var file_lines = File.ReadAllLines(filename);
        var new_content = file_lines.Append(content);

        string data_to_write = "";
        foreach (string line in new_content)
        {
            data_to_write += line + "\n";
        }
        File.WriteAllText(filename, data_to_write);
    }

    /* Reads from a text file */
    public static dynamic readFile(string filename)
    {
        var file_lines = File.ReadAllLines(filename);
        return file_lines;
    }

    /* Creates a .txt file, writes given content, and saves it to examArchives folder */
    public static void createFile(string filename, string content)
    {
        File.WriteAllText(filename, content);
    }
}
