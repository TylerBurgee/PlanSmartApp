using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Xml.Linq;
using System.Linq;

public class Login
{
	public Login()
	{
	}

	/*Verify user's login credentials*/
	public static bool verifyCredentials(string username, string password)
	{
		var user_info = FileIO.read_file(username + ".json");

		if (password == user_info.GetValue(1))
		{
            return true;
        }
		else
		{
			return false;
		}
	}

    /*Create a new user account*/
    public static bool signup(string firstName, string lastName, string email, string username, string password)
	{
		// Create dictionary with user's info
        Dictionary<string, string> user_info = new Dictionary<string, string>();
        user_info.Add("firstName", firstName);
        user_info.Add("lastName", lastName);
        user_info.Add("email", email);
        user_info.Add("username", username);
        user_info.Add("password", password);

		string filename = username + ".json";

		FileIO.create_file(filename);
		FileIO.write_to_file(filename, user_info);

        return true;
    }
}
