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
    }
}
