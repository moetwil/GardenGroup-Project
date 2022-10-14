using Garden_Group.UserControls;
using GardenGroupModel;
using GardenGroupLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Garden_Group.Forms
{
    public partial class TicketOverviewForm : Form
    {
        private User user;
        private List<Ticket> tickets;
        private TicketService ticketService;
        
        public TicketOverviewForm(User user)
        {
            this.user = user;
            ticketService = new TicketService();
            InitializeComponent();

        }

        private void TicketOverviewForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(new MenuStripUC(this.user, this));
            this.SetSizeToDesktop();
            labelTicketOverview.Text = $"Tickets overzicht van {user.FirstName}";
            /*tickets = ticketService.GetTicketsFromUser(user);*/
            
            fillOverview();
        }
        private void fillOverview()
        {
            foreach (Ticket ticket in this.user.Tickets)
            {
                TicketUC ticketConrtol = new TicketUC(ticket, this);
                ticketConrtol.WasClicked += TicketConrtol_WasClicked;
                flowTicketOverview.Controls.Add(ticketConrtol);
            }
        }
        
        public void TicketConrtol_WasClicked(object sender, EventArgs e)
        {
            TicketUC clickedTicket = (TicketUC)sender;
            labelInfoTitle.Text = ((Ticket)clickedTicket.Tag).Title;
            labelDescription.Text = ((Ticket)clickedTicket.Tag).Description;
            labelDateOpen.Text = ((Ticket)clickedTicket.Tag).TicketDate.OpeningDate.ToShortDateString();
            labelDateClose.Text = ((Ticket)clickedTicket.Tag).TicketDate.ClosingDate.ToShortDateString();
            labelDateDeadline.Text = ((Ticket)clickedTicket.Tag).TicketDate.Deadline.ToShortDateString();
            /*labelIncidentType.Text = ((Ticket)clickedTicket.Tag).TypeOfIncident.Type;
            labelPriority.Text = ((Ticket)clickedTicket.Tag).TicketPriority.PriorityLevel;
            labelStateName.Text = ((Ticket)clickedTicket.Tag).TicketState.Name;
            labelStateCode.Text = ((Ticket)clickedTicket.Tag).TicketState.Code.ToString();   */            
        }

        private void buttonIncidentAanmaken_Click(object sender, EventArgs e)
        {
            this.Hide();
            TicketAddingForm form = new TicketAddingForm(this.user);
            form.ShowDialog();
            this.Close();
        }

        private void buttonHighPriority_Click(object sender, EventArgs e)
        {
            var sort = Builders<BsonDocument>.Sort.Descending("TicketPriorityId");
        }
    }
}
