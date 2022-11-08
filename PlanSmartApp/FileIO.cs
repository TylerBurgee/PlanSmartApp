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

	public static void read_file(string filename)
	{
		string text = File.ReadAllText(filename);
		var file = JsonSerializer.Deserialize<Client>(text);
        MessageBox.Show(file.username);

    }

	/* Creates new, empty .json file */
	public static void create_file(string filename)
	{
		using (FileStream fs = File.Create(filename));
    }
	
	/* Create new sub-dictionary within .json file */
	public static void create_subdict(string filename, Dictionary<string, string> new_subdict)
	{
        string text = File.ReadAllText(filename);
        MessageBox.Show(text);
        // Sub-dictionaries looks like this within the .json file: 
        // {id1: {key1: value1, key2: value2}, id2: {key1: value1, key2: value2}}
        string dataToWrite = text + "{\"1000\": {";
		foreach (KeyValuePair<string, string> element in new_subdict)
		{
            dataToWrite = dataToWrite + "\"" + element.Key + "\":\"" + element.Value + "\",";

        } 
        dataToWrite = dataToWrite + "}}";

		//MessageBox.Show(dataToWrite);

        System.IO.File.WriteAllText(filename, dataToWrite);
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
