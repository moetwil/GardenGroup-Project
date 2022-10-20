using Garden_Group.UserControls;
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
using GardenGroupModel.Enums;
using System.Text.RegularExpressions;

namespace Garden_Group.Forms
{
    public partial class UserManagementForm : Form
    {
        private User user;
        private UserService userService;
        public User SelectedUser;
        public UserManagementForm(User user)
        {
            this.user = user;
            InitializeComponent();
            this.SetSizeToDesktop();

            // Load service objects
            this.userService = new UserService();
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(new MenuStripUC(this.user, this));
            List<User> allUsers = this.userService.GetAllUsers();
            LoadUsersInFlowPanel(allUsers);
            FillComboBoxes();
        }

        private void LoadUsersInFlowPanel(List<User> users)
        {
            foreach (User user in users)
            {
                this.flowLayoutPanelUsers.Controls.Add(new UserUC(user, this.panelUserInformation));
            }
        }

        // Fill comboboxes
        private void FillComboBoxes()
        {
            this.comboBoxCompanyRole.DataSource = Enum.GetValues(typeof(Role));
            this.comboBoxLocation.DataSource = Enum.GetValues(typeof(Branch));
        }
        private void SuccesMessage(string text)
        {
            labelErrorHandling.ForeColor = Color.Green;
            labelErrorHandling.Text = text;
        }

        private void ErrorMessage(string text)
        {
            labelErrorHandling.ForeColor = Color.Red;
            labelErrorHandling.Text = text;
        }
        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            // get last selected usercontrol from flowpanellayout
            UserUC userUC = (UserUC)this.flowLayoutPanelUsers.Controls[this.flowLayoutPanelUsers.Controls.Count - 1];
            UserService userService = new UserService();

            try
            {
                // read data and change user
                checkForEmptyChoices();
                this.SelectedUser.FirstName = textBoxFirstname.Text;
                this.SelectedUser.LastName = textBoxLastname.Text;
                this.SelectedUser.DateOfBirth = dateTimePickerDateOfBirth.Value;
                this.SelectedUser.JobInfo.Role = (Role)comboBoxCompanyRole.SelectedItem;
                this.SelectedUser.JobInfo.Branch = (Branch)comboBoxLocation.SelectedItem;
                this.SelectedUser.ContactInfo.Email = textBoxEmail.Text;
                this.SelectedUser.ContactInfo.PhoneNumber = textBoxPhoneNumber.Text;
                this.SelectedUser.ContactInfo.Address.Street = textBoxStreet.Text;
                this.SelectedUser.ContactInfo.Address.HouseNumber = textBoxHouseNumber.Text;
                this.SelectedUser.ContactInfo.Address.PostalCode = textBoxPostalCode.Text;
                this.SelectedUser.ContactInfo.Address.City = textBoxCity.Text;
                this.SelectedUser.ContactInfo.Address.Country = textBoxCountry.Text;

                userService.UpdateUser(this.SelectedUser);
                SuccesMessage("Gebruiker is met succes aangepast. ");
            }
            catch (Exception ex)
            {
                // show exception in label
                ErrorMessage(ex.Message);
                ErrorLogService errorLogService = new ErrorLogService();
                errorLogService.CatchExeptionToLog(ex);
            }
        }

        private void checkForEmptyChoices() 
        {
            // check if all fields are filled in
            if (textBoxFirstname.Text == "" || textBoxLastname.Text == "" || textBoxEmail.Text == "" || textBoxPhoneNumber.Text == "" || textBoxStreet.Text == "" || textBoxHouseNumber.Text == "" || textBoxPostalCode.Text == "" || textBoxCity.Text == "" || textBoxCountry.Text == "" || dateTimePickerDateOfBirth.Value == null || comboBoxCompanyRole.SelectedItem == null || comboBoxLocation.SelectedItem == null)
            {
                throw new Exception("Niet alle velden zijn ingevuld.");
            }
            // if phone number are not numbers throw exception
            if (!textBoxPhoneNumber.Text.All(char.IsDigit))
            {
                throw new Exception("Telefoonnummer mag alleen cijfers bevatten");
            }
            if (!ValidateEmail(textBoxEmail.Text) || CheckIfEmailExists(textBoxEmail.Text)) 
            {
                throw new Exception("Dit email adres is niet geldig of al in gebruik.");
            }
        }

        // Check if email is valid
        private bool ValidateEmail(string email)
        {
            return new Regex(@"^[a-zA-Z0-9._%-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,3}").Match(email).Success;
        }

        // Check if email is unique
        private bool CheckIfEmailExists(string email)
        {
            UserService userService = new UserService();
            return userService.CheckIfEmailExists(email);
        }
    }
}
