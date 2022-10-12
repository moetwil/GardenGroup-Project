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

namespace Garden_Group.UserControls
{
    public partial class UserUC : UserControl
    {
        private User user;
        private TicketService ticketService;
        private Panel panelUserInformation;

        public UserUC(User user, Panel panelUserInformation)
        {
            this.user = user;
            this.panelUserInformation = panelUserInformation;
            InitializeComponent();

            // Load service objects
            this.ticketService = new TicketService();
        
            Load();
        }

        private void Load()
        {
            this.labelFirstName.Text = this.user.FirstName;
            this.labelLastName.Text = this.user.LastName;
            this.labelEmail.Text = this.user.ContactInfo.Email;
            this.labelAmountOfTickets.Text = this.ticketService.GetTicketsFromUser(this.user).Count.ToString();
        }

        private void UserUC_Click(object sender, EventArgs e)
        {
             //this.panelUserInformation.Controls.Clear();
              // get textboxes from panel
              TextBox textBoxFirstName = (TextBox)this.panelUserInformation.Controls.Find("textBoxFirstName", true)[0];
              TextBox textBoxLastName = (TextBox)this.panelUserInformation.Controls.Find("textBoxLastName", true)[0];
              TextBox textBoxEmail = (TextBox)this.panelUserInformation.Controls.Find("textBoxEmail", true)[0];
              TextBox textBoxPhoneNumber = (TextBox)this.panelUserInformation.Controls.Find("textBoxPhoneNumber", true)[0];
              TextBox textBoxStreet = (TextBox)this.panelUserInformation.Controls.Find("textBoxStreet", true)[0];
              TextBox textBoxHouseNumber = (TextBox)this.panelUserInformation.Controls.Find("textBoxHouseNumber", true)[0];
              TextBox textBoxPostalCode = (TextBox)this.panelUserInformation.Controls.Find("textBoxPostalCode", true)[0];
              TextBox textBoxCity = (TextBox)this.panelUserInformation.Controls.Find("textBoxCity", true)[0];
              TextBox textBoxCountry = (TextBox)this.panelUserInformation.Controls.Find("textBoxCountry", true)[0];
              DateTimePicker dateTimePickerDateOfBirth = (DateTimePicker)this.panelUserInformation.Controls.Find("dateTimePickerDateOfBirth", true)[0];
/*              ComboBox comboBoxCompanyRole = (ComboBox)this.panelUserInformation.Controls.Find("comboBoxCompanyRole", true)[0];
              ComboBox comboBoxLocation = (ComboBox)this.panelUserInformation.Controls.Find("comboBoxLocation", true)[0];*/


            textBoxFirstName.Text = this.user.FirstName;
            textBoxLastName.Text = this.user.LastName;
            dateTimePickerDateOfBirth.Value = this.user.DateOfBirth;
/*            comboBoxCompanyRole.SelectedIndex = GetRole();
            comboBoxLocation.SelectedItem = this.user.JobInfo.Branch;*/
            textBoxEmail.Text = this.user.ContactInfo.Email;
            textBoxPhoneNumber.Text = this.user.ContactInfo.PhoneNumber;
            textBoxStreet.Text = this.user.ContactInfo.Address.Street;
            textBoxHouseNumber.Text = this.user.ContactInfo.Address.HouseNumber;
            textBoxPostalCode.Text = this.user.ContactInfo.Address.PostalCode;
            textBoxCity.Text = this.user.ContactInfo.Address.City;
            textBoxCountry.Text = this.user.ContactInfo.Address.Country;

           // MessageBox.Show(comboBoxCompanyRole.Items.IndexOf(this.user.JobInfo.Role).ToString());

        }

        private int GetRole()
        {
            if (this.user.JobInfo.Role.JobName == "Employee") return 0;
            if (this.user.JobInfo.Role.JobName == "ServiceDeskEmployee") return 1;
            return -1;
        }
    }
}
