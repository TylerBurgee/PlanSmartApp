using Microsoft.VisualBasic;
using System;
using System.Net;
using System.Net.Mail;
using System.Text;

public class Email
{
	private NetworkCredential login;
    SmtpClient smtpclient;
    MailMessage msg;
    SmtpClient smtpClientChoice;
    public Email()
	{
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
        SmtpClient mySmtpClient = new SmtpClient("my.smtp.exampleserver.net");

        // set smtp-client with basicAuthentication
        mySmtpClient.UseDefaultCredentials = false;
        System.Net.NetworkCredential basicAuthenticationInfo = new
           System.Net.NetworkCredential("username", "password");
        mySmtpClient.Credentials = basicAuthenticationInfo;

        // add from,to mailaddresses
        MailAddress from = new MailAddress("test@example.com", "TestFromName");
        MailAddress to = new MailAddress("test2@example.com", "TestToName");
        MailMessage myMail = new System.Net.Mail.MailMessage(from, to);

        // add ReplyTo
        MailAddress replyTo = new MailAddress("reply@example.com");
        myMail.ReplyToList.Add(replyTo);

        // set subject and encoding
        myMail.Subject = "Test message";
        myMail.SubjectEncoding = System.Text.Encoding.UTF8;

        // set body-message and encoding
        myMail.Body = "<b>Test Mail</b><br>using <b>HTML</b>.";
        myMail.BodyEncoding = System.Text.Encoding.UTF8;
        // text or html
        myMail.IsBodyHtml = true;

        mySmtpClient.Send(myMail);
        /*
		string username = "";
		string password = "";

		login = new NetworkCredential(username, password);
		smtpClientChoice = new SmtpClient(client);
        smtpClientChoice.Port = Convert.ToInt32(port);
        smtpClientChoice.EnableSsl = chkSSL.Checked;
        smtpclient.Credentials = login;
		msg = new MailMessage { From = new MailAddress(username, "name", Encoding.UTF8) };
		msg.To.Add(new MailAddress("recipient"));
		msg.Subject = "subject";
		msg.Body = "body";
		msg.BodyEncoding = Encoding.UTF8;
		msg.IsBodyHtml = true;
		msg.Priority = MailPriority.Normal;
		*/
    }
}