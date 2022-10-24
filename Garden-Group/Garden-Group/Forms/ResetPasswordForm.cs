using GardenGroupLogica;
using GardenGroupModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing.Text;

namespace Garden_Group.Forms
{
    public partial class ResetPasswordForm : Form
    {
        private UserService userService;
        private PasswordService passwordService;
        private User user;
        private const int size = 50;
        public ResetPasswordForm()
        {
            InitializeComponent();
            this.SetSizeToDesktop();
            this.userService = new UserService();
            this.passwordService = new PasswordService();
            this.user = new User();
        }

        SmtpClient smtpClient = new SmtpClient("smtp.mailtrap.io")
        {
            Port = 2525,
            Credentials = new NetworkCredential("ab72e98e4fead6", "09b21e1738af1c"),
            EnableSsl = true,
        };

        public void SendPassword(string password)
        {
            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress("test@gmail.com"),
                Subject = "Your new GardenGroup password.",
                Body = $"" +
                $"" +
                $"<h1>Er is een nieuw wachtwoord voor je aangemaakt.</h1>" +
                $"<p>Password: {password}</p> Dit is uw nieuwe wachtwoord.",
                IsBodyHtml = true,
            };

            mailMessage.To.Add("luc.moetwil@gmail.com");

            smtpClient.Send(mailMessage);

        }

        private void SendEmailButton_Click(object sender, EventArgs e)
        {
            string email = SendEmailTextBox.Text;
            string newPassword = passwordService.generateRandomPassword();

            user.Password = passwordService.GenerateSaltedHash(size, newPassword);

            userService.UpdatePassword(email, user);
            
            if (userService.CheckIfEmailExists(email))
            {
                SendPassword(newPassword);
                ReactionLabel.Text = "Er is een nieuw wachtwoord naar uw email gestuurd";
                ReactionLabel.ForeColor = Color.Green;
            }
            else
            {
                ReactionLabel.Text = "This email does not exist.";
                ReactionLabel.ForeColor = Color.Red;
            }
        }

        private void buttonBackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
