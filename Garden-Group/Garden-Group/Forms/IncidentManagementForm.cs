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

namespace Garden_Group.Forms
{
    public partial class IncidentManagementForm : Form
    {
        private User user;
        private Ticket selectedTicket;
        private List<Ticket> allTickets;
        private TicketService ticketService;
        private IncidentsUC selectedIncidentUC;

        private void IncidentManagementForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(new MenuStripUC(this.user, this));
            fillFlowPanel(this.allTickets);
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

/*        private void IncidentManagementForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(new MenuStripUC(this.user, this));
            fillFlowPanel();
            loadComboBoxes();
        }*/

        private void fillFlowPanel(List<Ticket> tickets)
        {
            flowLayoutPanelIncidents.Controls.Clear();
            foreach (Ticket ticket in tickets)
            {
                IncidentsUC incidentUC = new IncidentsUC(ticket, this);
                incidentUC.Clicked += IncidentUC_Clicked;
                incidentUC.Size = new Size(flowLayoutPanelIncidents.Width - SystemInformation.HorizontalScrollBarArrowWidth, 70);
                flowLayoutPanelIncidents.Controls.Add(incidentUC);
            }
        }

        /*private void loadComboBoxes()
        {
            List<TicketPriority> priorityLevels = ticketPriorityService.GetAllTicketPriorities();
            ticketStates = ticketStateService.GetAllTicketStates();
            List<TicketIncident> ticketIncidents = ticketIncidentService.GetAllTicketIncidents();

            foreach (TicketPriority priority in priorityLevels)
                comboBoxPriority.Items.Add(priority);
            foreach (TicketState state in ticketStates)
                comboBoxState.Items.Add(state);
            foreach (TicketIncident incident in ticketIncidents)
                comboBoxType.Items.Add(incident);
        }*/

        private void IncidentUC_Clicked(object sender, EventArgs e)
        {
            buttonBecomeSolver.Enabled = true;
            selectedIncidentUC = (IncidentsUC)sender;
            this.selectedTicket = (Ticket)selectedIncidentUC.Tag;

            labelTitle.Text = ((Ticket)selectedIncidentUC.Tag).Title;
            richTextBoxDescription.Text = ((Ticket)selectedIncidentUC.Tag).Description;
            //labelStateCode.Text = ((Ticket)selectedIncidentUC.Tag).TicketState.Code.ToString();
            //labelCreatorName.Text = ((Ticket)selectedIncidentUC.Tag).Creator.FirstName + " " + ((Ticket)selectedIncidentUC.Tag).Creator.LastName;


            comboBoxPriority.SelectedItem = ((Ticket)selectedIncidentUC.Tag).TicketPriority;
            comboBoxState.SelectedItem = ((Ticket)selectedIncidentUC.Tag).TicketState;
            comboBoxType.SelectedItem = ((Ticket)selectedIncidentUC.Tag).TypeOfIncident;

            dateTimePickerOpen.Value = ((Ticket)selectedIncidentUC.Tag).TicketDate.OpeningDate.Date;
            /*if (((Ticket)selectedIncidentUC.Tag).TicketState == ticketStates[0])
                dateTimePickerClosed.Value = ((Ticket)selectedIncidentUC.Tag).TicketDate.ClosingDate.Date;*/

            //dateTimePickerDeadline.Value = ((Ticket)selectedIncidentUC.Tag).TicketDate.Deadline.Date;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ticketService.DeleteTicket((Ticket)selectedIncidentUC.Tag);
            flowLayoutPanelIncidents.Controls.Remove(selectedIncidentUC);
        }

        private void buttonBecomeSolver_Click(object sender, EventArgs e)
        {            
            ((Ticket)selectedIncidentUC.Tag).Solvers.Add(this.user);
            ((Ticket)selectedIncidentUC.Tag).TicketSolvers.Add(this.user.Id);

            ticketService.UpdateTicket(((Ticket)selectedIncidentUC.Tag));
            
            buttonBecomeSolver.Text = "Gelukt!";
            buttonBecomeSolver.Enabled = false;
        }

        /*private void buttonCloseTicket_Click(object sender, EventArgs e)
        {
            ((Ticket)selectedIncidentUC.Tag).TicketState = ticketStates[0];
            ((Ticket)selectedIncidentUC.Tag).TicketStateId = ticketStates[0].Id;            
            ((Ticket)selectedIncidentUC.Tag).TicketDate.ClosingDate = DateTime.UtcNow;
            
            ticketService.UpdateTicket(((Ticket)selectedIncidentUC.Tag));
        }*/

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
    }
}
