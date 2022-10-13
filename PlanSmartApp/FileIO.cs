using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Text.Json;
public class FileIO
{
	public FileIO() 
	{
	}

	/* Creates new, empty .json file*/
	public static void create_file(string filename)
	{
		using (FileStream fs = File.Create(filename));

    }
	
	/* Create new sub-dictionary within .json file*/
	public static void create_subdict(string filename, Dictionary<string, string> new_subdict)
	{
		// Sub-dictionaries looks like this within the .json file: 
		// {id1: {key1: value1, key2: value2}, id2: {key1: value1, key2: value2}}
		for (int i = 0; i < new_subdict.Count; i++)
		{

		}
		System.IO.File.WriteAllText(filename);
	}

	/* Delete sub-dictionary from .json file*/
	public static void delete_subdict(string filename)
	{
		File.Delete(filename);
	}

	/* Add new key-pair value to existing sub-dictionary within .json file
	public static void add_to_subdict(string filename, Dictionary<string, string> new)
	{
		new.add(string, string);
	}*/
}
