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
    public partial class TicketAddingForm : Form
    {
        private User user { get; set; }
        public TicketAddingForm(User user)
        {
            InitializeComponent();
            this.user = user;
            this.SetSizeToDesktop();
        }        
        private void TicketAddingForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(new MenuStripUC(this.user, this));
            this.AcceptButton = buttonAddTicket;
            FillCheckboxes();
        }
        private void buttonBackToDashBoard_Click(object sender, EventArgs e)
        {
            // go back to dashboard
            this.Hide();
            DashboardForm dashboardForm = new DashboardForm(this.user);
            dashboardForm.ShowDialog();
            this.Close();
        }

        // Use Service Layer to retrieve data from the database. 
        private void FillCheckboxes() {
            this.comboBoxTicketPriority.DataSource = Enum.GetValues(typeof(TicketPriority));
            this.comboBoxTicketStateState.DataSource = Enum.GetValues(typeof(TicketState));
            this.comboBoxTypeOfIncident.DataSource = Enum.GetValues(typeof(TicketIncident));
        }

        private void FillCombobox<T>(List<T> itemList, ComboBox comboBox) {
            foreach (T item in itemList) {
                comboBox.Items.Add(item); { Tag = item; };
            }
        }

        private void CheckForEmptyChoices()
        {
            if (textBoxTicketTitle.Text == String.Empty || textBoxTicketDescription.Text == String.Empty)
                throw new Exception("Alle velden met een '*' zijn verplicht. Gelieve deze in te vullen.");

            if (comboBoxTicketPriority.Text == String.Empty || comboBoxTicketStateState.Text == String.Empty || comboBoxTypeOfIncident.Text == String.Empty)
                throw new Exception("Alle velden met een '*' zijn verplicht. Gelieve een keuze te maken. ");
        }

        private void SuccesMessage(string text) {
            labelErrorHandling.ForeColor = Color.Green;
            labelErrorHandling.Text = text;
        }

        private void ErrorMessage(string text) {
            labelErrorHandling.ForeColor = Color.Red;
            labelErrorHandling.Text = text;
        }

        private void buttonAddTicket_Click(object sender, EventArgs e)
        {
            try
            {
                CheckForEmptyChoices();                
                // add ticket to database
                Ticket ticket = new Ticket();
                ticket.Title = textBoxTicketTitle.Text;
                ticket.Description = textBoxTicketDescription.Text;
                ticket.CreatorID = this.user.Id;
                ticket.TicketSolvers = new List<string>();
                ticket.TicketDate = new TicketDate();
                ticket.TicketDate.OpeningDate = DateTime.Now;
                ticket.TicketDate.Deadline = dateTimePickerTicketDeadline.Value;
                ticket.TicketPriority = ((TicketPriority)this.comboBoxTicketPriority.SelectedItem);
                ticket.TicketState = ((TicketState)this.comboBoxTicketStateState.SelectedItem);
                ticket.TypeOfIncident = ((TicketIncident)this.comboBoxTypeOfIncident.SelectedItem);

                // add ticket to database
                TicketService ticketService = new TicketService();
                ticketService.AddTicket(ticket);

                EmailService emailService = new EmailService();
                emailService.SendTicketToEmail(this.user.ContactInfo.Email.ToLower(), ticket);

                // messagebox to confirm ticket is added
                SuccesMessage("Ticket is toegevoegd. Er is een mail verzonden als bevestiging. Check uw inbox. ");
                ClearAllTextInForm();
            }
            catch (Exception ex)
            {
                // show exception in label
                ErrorMessage(ex.Message);
                ErrorLogService errorLogService = new ErrorLogService();
                errorLogService.CatchExeptionToLog(ex);
            }
        }
        private void ClearAllTextInForm() {
            textBoxTicketDescription.Clear();
            textBoxTicketTitle.Clear();
            comboBoxTicketPriority.ResetText();
            comboBoxTicketStateState.ResetText();
            comboBoxTypeOfIncident.ResetText();
            dateTimePickerTicketDeadline.ResetText();
        }
        private void buttonTicketCancel_Click(object sender, EventArgs e)
        {
            // ask user if they are sure to cancel ticket by showing messagebox
            DialogResult dialogResult = MessageBox.Show("Weet u zeker dat u het ticket wilt annuleren?", "Annuleren", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // clear all text in form
                ClearAllTextInForm();
                // return to dashoard
                this.Hide();
                DashboardForm dashboardForm = new DashboardForm(this.user);
                dashboardForm.ShowDialog();
                this.Close();
            }
        }
    }
}
