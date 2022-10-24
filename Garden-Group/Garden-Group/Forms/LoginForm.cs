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

namespace Garden_Group.Forms
{
    public partial class LoginForm : Form
    {
        private User user;
        private UserService userService;
        private LoginService loginService;
        private CreateUserForm createUserForm;

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = buttonLogin;
        }

        public LoginForm()
        {
            InitializeComponent();
            this.userService = new UserService();
            this.loginService = new LoginService();
            this.SetSizeToDesktop();
            //TestLogin();
        }

        public void TestLogin()
        {
            UserService userService = new UserService();

            // Get last user from the collection for testing only!
            List<User> allUsers = userService.GetAllUsers();
            this.user = allUsers[1];

        }

        public void OpenDashboardForm()
        {
            this.Hide();
            DashboardForm dashboardForm = new DashboardForm(this.user);
            dashboardForm.ShowDialog();
            this.Close();
        }

        public void OpenForgotPasswordForm()
        {
            this.Hide();
            ResetPasswordForm resetPasswordForm = new ResetPasswordForm();
            resetPasswordForm.ShowDialog();
            this.Close();
        }
        
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email = EmailBox.Text;
            string password = PasswordBox.Text;
            this.user = userService.FindUserByEmail(email.ToLower());

            if (loginService.CheckPassword(email.ToLower(), password))
            {
                OpenDashboardForm();
            }
            else
            {
                CheckTextBoxes();
            }
        }

        private void CheckTextBoxes()
        {
            try
            {
                if (EmailBox.Text == String.Empty && PasswordBox.Text != String.Empty)
                {
                     throw new Exception("Please enter your email");
                }
                else if (EmailBox.Text != String.Empty && PasswordBox.Text == String.Empty)
                {
                    throw new Exception("Please enter your password");
                }
                else if (EmailBox.Text == String.Empty && PasswordBox.Text == String.Empty)
                {
                    throw new Exception("Please enter your email address and password");
                }
                else
                {
                    throw new Exception("Email address or password is incorrect");
                }
            }
            catch (Exception ex)
            {
                ErrorMessage.Text = ex.Message;
                ErrorLogService errorLogService = new ErrorLogService();
                errorLogService.CatchExeptionToLog(ex);
            }
            
            
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            OpenDashboardForm();
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenForgotPasswordForm();
        }
    }
}
