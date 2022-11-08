using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Xml.Linq;

public class Login
{
	private static string filename = "userAccounts.json";

	public Login()
	{
	}

	/*Verify user's login credentials*/
	public static bool verifyCredentials(string username, string password)
	{
		return true;
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

		//FileIO.create_file(filename);
		// Create a subdict to store new user's info
		FileIO.create_subdict(filename, user_info);

		return true;
    }
}
