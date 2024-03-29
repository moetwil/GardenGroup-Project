﻿using Garden_Group.UserControls;
using GardenGroupLogica;
using GardenGroupModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using GardenGroupModel.Enums;

namespace Garden_Group.Forms
{
    public partial class CreateUserForm : Form
    {

        public User LoggedInUser { get; set; }
        public User NewUser { get; set; }
        public CreateUserForm(User user)
        {
            this.LoggedInUser = user;
            this.NewUser = new User();

            InitializeComponent();
            this.SetSizeToDesktop();
        }

        private void CreateUserForm_Load(object sender, EventArgs e)
        {
            // Add the menu and show the first panel + fill the comboboxes with data from the db
            this.Controls.Add(new MenuStripUC(this.LoggedInUser, this));
            FillComboBoxes();

            // Hide labelMessage
            this.labelMessage.Hide();
        }

        // Button click methods

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                // Check for valid fields
                CheckValidFields();

                // Create the user with all input
                CreateUser();

                // Create random password for the user 
                PasswordService passwordService = new PasswordService();
                string password = passwordService.generateRandomPassword();
                this.NewUser.Password = passwordService.GenerateSaltedHash(50, password);

                // Add user to the database
                UserService userService = new UserService();
                userService.AddUser(this.NewUser);

                // Send password to user's email
                EmailService emailService = new EmailService();
                emailService.SendPassword(NewUser.ContactInfo.Email, password);

                this.labelMessage.Text = "Gebruiker is aangemaakt!";
                this.labelMessage.ForeColor = Color.Green;
                this.labelMessage.Show();
            }
            catch (Exception ex)
            {
                this.ShowMessageLabel(ex.Message);
                ErrorLogService errorLogService = new ErrorLogService();
                errorLogService.CatchExeptionToLog(ex);
            }
        }


        private void CreateUser()
        {
            this.NewUser.FirstName = this.textBoxFirstname.Text;
            this.NewUser.LastName = this.textBoxLastname.Text;
            this.NewUser.DateOfBirth = this.dateTimePickerDoB.Value;
            this.NewUser.JobInfo.Role = (Role)this.comboBoxRole.SelectedItem;
            this.NewUser.JobInfo.Branch = (Branch)this.comboBoxLocationBranch.SelectedItem;
            this.NewUser.ContactInfo.Email = this.textBoxEmail.Text;
            this.NewUser.ContactInfo.PhoneNumber = this.textBoxPhone.Text;
            this.NewUser.ContactInfo.Address.Street = this.textBoxStreet.Text;
            this.NewUser.ContactInfo.Address.HouseNumber = this.textBoxHouseNumber.Text;
            this.NewUser.ContactInfo.Address.City = this.textBoxCity.Text;
            this.NewUser.ContactInfo.Address.PostalCode = this.textBoxPostalCode.Text;
            this.NewUser.ContactInfo.Address.Country = this.textBoxCountry.Text;
        }
        private void ShowMessageLabel(string message)
        {
            this.labelMessage.Text = message;
            this.labelMessage.Show();
        }

        // Check empty fields
        private bool CheckForEmpty()
        {
            if (this.textBoxFirstname.Text == "" ||
                this.textBoxLastname.Text == "" ||
                this.comboBoxRole.SelectedItem == null ||
                this.comboBoxLocationBranch.SelectedItem == null ||
                this.dateTimePickerDoB.Value == null ||
                this.textBoxEmail.Text == "" ||
                this.textBoxPhone.Text == "" ||
                this.textBoxStreet.Text == "" ||
                this.textBoxHouseNumber.Text == "" ||
                this.textBoxCity.Text == "" ||
                this.textBoxPostalCode.Text == "" ||
                this.textBoxCountry.Text == "")
                throw new Exception("Vul alle velden in");

            return false;
        }
        
        // Check valid fields
        private bool CheckValidFields()
        {
            if (!ValidateEmail(this.textBoxEmail.Text))
                throw new Exception("Email is niet geschikt");
            else if (CheckIfEmailExists(this.textBoxEmail.Text))
                throw new Exception("Email wordt al gebruikt");

            return false;
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

        // Fill comboboxes
        private void FillComboBoxes()
        {
            this.comboBoxRole.DataSource = Enum.GetValues(typeof(Role));
            this.comboBoxLocationBranch.DataSource = Enum.GetValues(typeof(Branch));
        }
        
    }
}
