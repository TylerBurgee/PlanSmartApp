using Microsoft.VisualBasic;
using System;
using System.Net;
using System.Net.Mail;
using System.Text;

public class Email
{
	public Email()
	{
		NetworkCredential login;
		SmtpClient client;
		MailMessage msg;
	}

	public void sendInvitation(string subject, string body)
	{
		return;
	}

    public void sendNotification(string subject, string body)
    {
        return;
    }

	public void loginMethod(string username, string password)
	{
		// filler
		
	}

	public void smtpServer(string client, string port)
	{
		login = new NetworkCredential(username, password);
		smtpClientChoice = new SmtpClient(client);
		stmpClientChoice.Port = Convert.ToInt32(port);
		stmpClientChoice.EnableSsl = chkSSL.Checked;
		client.Credentials = Login;
		msg = new MailMessage { From = new MailAddress(username, "name", Encoding.UTF8)}
		msg.To.Add(new MailAddress("recipient"))
		msg.Subject = "subject"
		msg.Body = "body"
		msg.BodyEncoding = Encoding.UTF8
		msg.IsBodyHtml = true;
		msg.Priority = MailPriority.Normal
	}
}