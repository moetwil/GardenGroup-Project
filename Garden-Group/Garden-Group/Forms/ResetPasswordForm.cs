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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Garden_Group.Forms
{
    public partial class ResetPasswordForm : Form
    {
        private UserService userService;
        private PasswordService passwordService;
        private User user;
        private EmailService emailService;
        private const int Size = 50;
        private const int CodeLength = 6;
        private string code;
        private string email = "";
        public ResetPasswordForm()
        {
            InitializeComponent();
            this.SetSizeToDesktop();
            this.userService = new UserService();
            this.passwordService = new PasswordService();
            this.user = new User();
            this.emailService = new EmailService();

            this.code = RandomCode();

            SendCodePanel.Visible = true;
            ChangePasswordPanel.Visible = false;
            InsertCodePanel.Visible = false;
        }
        
        private string RandomCode()
        {
            for (int i = 0; i < CodeLength; i++)
            {
                Random random = new Random();
                this.code += random.Next(0, 10).ToString();
            }
            return code;
        }

        private void SendEmailButton_Click(object sender, EventArgs e)
        {
            email = SendEmailTextBox.Text;
            
            if (userService.CheckIfEmailExists(email))
            {
                emailService.SendCode(SendEmailTextBox.Text, code);
                ReactionLabel.Text = "De code is naar uw email gestuurd";
                ReactionLabel.ForeColor = Color.Green;


                SendCodePanel.Visible = false;
                InsertCodePanel.Visible = true;
            }
            else
            {
                ReactionLabel.Text = "This email does not exist.";
                ReactionLabel.ForeColor = Color.Red;
            }
        }

        private void CheckCodeButton_Click(object sender, EventArgs e)
        {
            if (CodeCheckBox.Text == code)
            {
                InsertCodePanel.Visible = false;
                ChangePasswordPanel.Visible = true;
            }
            else if (CodeCheckBox.Text == null)
            {
                ReactionLabel.Text = "U heeft geen code ingevuld.";
                ReactionLabel.ForeColor = Color.Red;
            }
            else
            {
                ReactionLabel.Text = "De code is onjuist.";
                ReactionLabel.ForeColor = Color.Red;
            }
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            if (FirstPasswordBox.Text == SecondPasswordBox.Text)
            {
                user.Password = passwordService.GenerateSaltedHash(Size, FirstPasswordBox.Text);

                userService.UpdatePassword(email, user);

                FirstPasswordBox.Text = "";
                SecondPasswordBox.Text = "";

                ReactionLabelPasswordChange.Text = "Uw wachtwoord is veranderd.";
                ReactionLabelPasswordChange.ForeColor = Color.Green;
            }
            else if (FirstPasswordBox.Text == null || SecondPasswordBox.Text == null)
            {
                ReactionLabelPasswordChange.Text = "Een van de velden is niet ingevuld.";
            }
            else if (FirstPasswordBox.Text != SecondPasswordBox.Text)
            {
                ReactionLabelPasswordChange.Text = "De de velden zijn niet gelijk";
            }
            else
            {
                ReactionLabelPasswordChange.Text = "De velden zijn leeg";
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
