using Microsoft.VisualBasic;
using System;
using System.Net;
using System.Net.Mail;
using System.Text;

public class Email
{

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

	public void smtpServer()
	{
        SmtpClient mySmtpClient = new SmtpClient("smtp-mail.outlook.com", 587);
        mySmtpClient.EnableSsl = true;

        // set smtp-client with basicAuthentication
        mySmtpClient.UseDefaultCredentials = false;
        NetworkCredential basicAuthenticationInfo = new
        NetworkCredential("plansmartapp@outlook.com", "TylerIanMarc");
        mySmtpClient.Credentials = basicAuthenticationInfo;

        // add from,to mailaddresses
        MailAddress from = new MailAddress("plansmartapp@outlook.com", "PlanSmart App");
        MailAddress to = new MailAddress("cupofjoe2002@icloud.com", "Joey Burgee");
        MailMessage myMail = new MailMessage(from, to);

        // set subject and encoding
        myMail.Subject = "Test message";
        myMail.SubjectEncoding = Encoding.UTF8;

        // set body-message and encoding
        myMail.Body = "<b>Test Mail</b><br>using <b>HTML</b>.";
        myMail.BodyEncoding = Encoding.UTF8;
        // text or html
        myMail.IsBodyHtml = true;

        mySmtpClient.Send(myMail);
    }
}