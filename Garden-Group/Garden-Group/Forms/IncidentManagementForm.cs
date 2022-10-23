using Garden_Group.UserControls;
using GardenGroupLogica;
using GardenGroupLogica.Individual;
using GardenGroupModel;
using GardenGroupModel.Enums;
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
{   //TODO wanneer er gesorteerd is en prioriteit wordt aangepast, dan wordt de sortering niet meer toegepast
    public partial class IncidentManagementForm : Form
    {
        private User user;
        private Ticket? selectedTicket;
        private List<Ticket> allTickets;
        private TicketService ticketService;
        private IncidentsUC? selectedIncidentUC;

        private void IncidentManagementForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(new MenuStripUC(this.user, this));
            
            fillFlowPanel(this.allTickets);
            loadComboBoxes();
            
            this.panelTransfer.Visible = false;
            this.labelErrorHandling.Visible = false;
            this.textBoxFilter.Visible = false;
        }

        public IncidentManagementForm(User user)
        {
            this.user = user;
            ticketService = new TicketService();
            this.allTickets = ticketService.GetAllTickets();

            InitializeComponent();
            this.SetSizeToDesktop();
        }

        private void loadComboBoxes()
        {
            this.comboBoxType.DataSource = Enum.GetValues(typeof(TicketIncident));
            this.comboBoxPriority.DataSource = Enum.GetValues(typeof(TicketPriority));
        }

        private void fillFlowPanel(List<Ticket> tickets)
        {
            flowLayoutPanelIncidents.Controls.Clear();
            //List<IncidentsUC> incidents = new List<IncidentsUC>();
            
            foreach (Ticket ticket in tickets)
            {
                IncidentsUC incidentUC = new IncidentsUC(ticket, this);
                incidentUC.Clicked += IncidentUC_Clicked;
                incidentUC.Size = new Size(flowLayoutPanelIncidents.Width - SystemInformation.HorizontalScrollBarArrowWidth, 70);
                
                //incidents.Add(incidentUC);
                //if (incidents.Count == 10)
                //{
                //    flowLayoutPanelIncidents.Controls.AddRange(incidents.ToArray());
                //    incidents = new List<IncidentsUC>();
                //}
                flowLayoutPanelIncidents.Controls.Add(incidentUC);
            }
            //flowLayoutPanelIncidents.Controls.AddRange(incidents.ToArray());
        }

        private void IncidentUC_Clicked(object sender, EventArgs e)
        {
            buttonBecomeSolver.Enabled = true;
            
            selectedIncidentUC = (IncidentsUC)sender;
            this.selectedTicket = (Ticket)selectedIncidentUC.Tag;
            textBoxTitle.Text = ((Ticket)selectedIncidentUC.Tag).Title;
            richTextBoxDescription.Text = ((Ticket)selectedIncidentUC.Tag).Description;
            labelTicketState.Text = ((Ticket)selectedIncidentUC.Tag).TicketState.ToString();
            comboBoxPriority.SelectedItem = ((Ticket)selectedIncidentUC.Tag).TicketPriority;            
            comboBoxType.SelectedItem = ((Ticket)selectedIncidentUC.Tag).TypeOfIncident;
            dateTimePickerDeadline.Value = ((Ticket)selectedIncidentUC.Tag).TicketDate.Deadline.Date;            
            labelCreatorName.Text = new UserService().GetUserById(((Ticket)selectedIncidentUC.Tag).CreatorId).ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ticketService.DeleteTicket((Ticket)selectedIncidentUC.Tag);
            flowLayoutPanelIncidents.Controls.Remove(selectedIncidentUC);
        }

        private void buttonBecomeSolver_Click(object sender, EventArgs e)
        {
            if (selectedTicket.TicketState != TicketState.Open)
            {
                labelFeedBack.Text = "Ticket heeft al een werknemer. U kunt mogelijk gebruik maken van de transfer knop";
                return;
            }

            selectedTicket.TicketState = TicketState.InProgress;
            selectedTicket.ServiceDeskEmployeeId = this.user.Id;
            
            ticketService.UpdateTicket(selectedTicket);
            selectedIncidentUC.FillUC();

            labelFeedBack.Text = "U bent nu de solver van de ticket";
            buttonBecomeSolver.Enabled = false;
        }

        private void buttonCloseTicket_Click(object sender, EventArgs e)
        {                
            if (selectedTicket.TicketState == TicketState.Closed || selectedTicket.TicketState == TicketState.Cancelled)
            {
                labelFeedBack.Text = "Ticket is al gesloten of gecancelled";
                return;
            }
            
            string feedback = string.Empty;
            TicketState ticketState;
            
            if (selectedTicket.TicketState == TicketState.Open)
            {
                feedback = "Ticket is niet in behandeling, handeling is gecancelled";
                ticketState = TicketState.Cancelled;
            }
            else
            {
                feedback = "Ticket is gesloten";
                ticketState = TicketState.Closed;
            }

            selectedTicket.TicketDate.ClosingDate = DateTime.Now;
            selectedTicket.TicketState = ticketState;
            labelFeedBack.Text = feedback + " " + selectedTicket.TicketDate.ClosingDate.Date;
            ticketService.UpdateTicket(selectedTicket);
            selectedIncidentUC.FillUC();
        }

        private void buttonEditTicket_Click(object sender, EventArgs e)
        {

            if (this.selectedTicket != null)
            {
                selectedTicket.Title = textBoxTitle.Text;
                selectedTicket.Description = richTextBoxDescription.Text;
                selectedTicket.TicketPriority = (TicketPriority)comboBoxPriority.SelectedItem;
                selectedTicket.TypeOfIncident = (TicketIncident)comboBoxType.SelectedItem;
                selectedTicket.TicketDate.Deadline = dateTimePickerDeadline.Value;
                ticketService.UpdateTicket(selectedTicket);
                selectedIncidentUC.FillUC();
            }
        }
        private void buttonAddTicket_Click(object sender, EventArgs e)
        {
            TicketAddingForm form = new TicketAddingForm(this.user);

            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void checkBoxTransfer_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                UserService userService = new UserService();
                comboBoxTransfer.Items.Clear();

                if (checkBoxTransfer.Checked)
                {
                    this.panelTransfer.Visible = true;
                    this.panelTransfer.Show();
                    foreach (User user in userService.GetAllUsers())
                    {
                        comboBoxTransfer.Items.Add(user);
                    }
                }
                else
                {
                    this.panelTransfer.Visible = false;
                    this.panelTransfer.Hide();
                }
            }
            catch (Exception ex)
            {
                this.labelErrorHandling.Text = ex.Message;
                this.labelErrorHandling.Visible = true;
            }       
        }

        private void comboBoxTransfer_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            User newEmployee = (User)this.comboBoxTransfer.SelectedItem;
            TicketTransferService ticketTransferService = new TicketTransferService();
            ticketTransferService.TransferTicket(this.selectedTicket, newEmployee);
        }
        
        private void checkBoxFilter_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxFilter.Checked)
            {
                this.textBoxFilter.Visible = true;
                this.textBoxFilter.Clear();

                // set users cursor in textbox
                this.textBoxFilter.Focus();

            }
            else
            {
                this.textBoxFilter.Visible = false;
                fillFlowPanel(this.allTickets);
            }
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            // if the checkbx of the filter is not checked, do nothing
            if (!this.checkBoxFilter.Checked) return;

            // filter allTickets on the text in the textbox
            List<Ticket> filteredTickets = IncidentManagementFilterService.FilterTickets(this.allTickets, this.textBoxFilter.Text);

            fillFlowPanel(filteredTickets);
        }

        private void checkBoxSort_CheckedChanged(object sender, EventArgs e)
        {
            this.buttonSortDescending.Visible = checkBoxSort.Checked; 
            this.buttonSortAscending.Visible = checkBoxSort.Checked;

            if (checkBoxSort.Checked)
            {
                buttonSortDescending.PerformClick();
                return;
            }                
            
            fillFlowPanel(this.allTickets);
        }

        private void buttonSortDescending_Click(object sender, EventArgs e)
        {
            this.buttonSortDescending.Enabled = false;
            this.buttonSortAscending.Enabled = true;
            
            getSortedTickets(true);
            fillFlowPanel(this.allTickets);
        }
        
        private void buttonSortAscending_Click(object sender, EventArgs e)
        {
            this.buttonSortDescending.Enabled = true;
            this.buttonSortAscending.Enabled = false;
            
            getSortedTickets(false);
            fillFlowPanel(this.allTickets);
        }
        
        private void getSortedTickets(bool descending)
        {
            TicketSortService ticketSortService = new TicketSortService();
            allTickets = ticketSortService.SortTicketsByPriority(descending);
        }
        
        private void getSortedByList(bool descending)
        {
            List<Ticket> sortedTickets = new List<Ticket>();
            
            if (descending)
                sortedTickets = this.allTickets.OrderByDescending(t => t.TicketPriority).ToList();            
            else
                sortedTickets = this.allTickets.OrderBy(t => t.TicketPriority).ToList();
            
            fillFlowPanel(sortedTickets);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text;
            
            if (search.Equals(String.Empty))
            {




                fillFlowPanel(this.allTickets);
                return;
            }
            
            IncidentManagementSearchService incidentManagementSearchService = new IncidentManagementSearchService();
            List<Ticket> searchTickets = incidentManagementSearchService.FindTicketsBySearchKeywords(search);
            fillFlowPanel(searchTickets);
        }
    }
}
