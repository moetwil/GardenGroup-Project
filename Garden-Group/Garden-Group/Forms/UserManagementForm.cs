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

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();

            try
            {
                // read data and change user
                this.user.FirstName = textBoxFirstname.Text;
                this.user.LastName = textBoxLastname.Text;
                this.user.DateOfBirth = dateTimePickerDateOfBirth.Value;
                /*this.user.JobInfo.RoleId = ((Role)comboBoxCompanyRole.SelectedItem).Id;
                this.user.JobInfo.BranchId = ((Branch)comboBoxLocation.SelectedItem).Id;*/
                this.user.ContactInfo.Email = textBoxEmail.Text;
                this.user.ContactInfo.PhoneNumber = textBoxPhoneNumber.Text;
                this.user.ContactInfo.Address.Street = textBoxStreet.Text;
                this.user.ContactInfo.Address.HouseNumber = textBoxHouseNumber.Text;
                this.user.ContactInfo.Address.PostalCode = textBoxPostalCode.Text;
                this.user.ContactInfo.Address.City = textBoxCity.Text;
                this.user.ContactInfo.Address.Country = textBoxCountry.Text;

                userService.UpdateUser(this.user);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
