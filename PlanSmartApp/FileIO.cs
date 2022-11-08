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
	
	/* Create new sub-dictionary within .json file */
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

	/* Delete sub-dictionary from .json file */
	public static void delete_subdict(string filename)
	{
		File.Delete(filename);
	}

	/* Add new key-pair value to existing sub-dictionary within .json file */
	public static void add_to_subdict(string filename)
	{

	}
}
