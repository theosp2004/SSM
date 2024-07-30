using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace SSM
{
    public partial class AddProblem : Form
    {
        public AddProblem()
        {
            InitializeComponent();
        }
        private void sendEmailButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Define the email details
                string fromAddress = "your-email@example.com";
                string toAddress = "recipient-email@example.com";
                string subject = "Subject of the email";
                string body = "Body of the email";
                string smtpServer = "smtp.example.com"; // Replace with your SMTP server
                int smtpPort = 587; // Replace with your SMTP port
                string smtpUsername = "your-email@example.com";
                string smtpPassword = "your-email-password";

                // Create the mail message
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromAddress);
                mail.To.Add(toAddress);
                mail.Subject = subject;
                mail.Body = body;

                // Configure the SMTP client
                SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort);
                smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                smtpClient.EnableSsl = true;

                // Send the email
                smtpClient.Send(mail);
                MessageBox.Show("Email sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email. Error: " + ex.Message);
            }
        }
    }
}
