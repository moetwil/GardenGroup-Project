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
        
        public TicketOverviewForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void TicketOverviewForm_Load(object sender, EventArgs e)
        {
            this.SetSizeToDesktop();
            this.Controls.Add(new MenuStripUC(this.user, this));
            
            labelTicketOverview.Text = $"Tickets overzicht van {user}";
            
            fillOverview();
            //updateListView();
        }
        
        private void fillOverview()
        {
            foreach (Ticket ticket in this.user.Tickets)
            {
                TicketUC ticketConrtol = new TicketUC(ticket, this);
                flowTicketOverview.Controls.Add(ticketConrtol);                
            }
        }
        public void TicketUc_Click(object sender, EventArgs e)
        {
            TicketUC clickedTicket = (TicketUC)sender;
            labelInfoTitle.Text = ((Ticket)clickedTicket.Tag).Title;
            labelDescription.Text = ((Ticket)clickedTicket.Tag).Description;
            labelDateOpen.Text = ((Ticket)clickedTicket.Tag).TicketDate.OpeningDate.ToShortDateString();
            labelDateClose.Text = ((Ticket)clickedTicket.Tag).TicketDate.ClosingDate.ToShortDateString();
            labelDateDeadline.Text = ((Ticket)clickedTicket.Tag).TicketDate.Deadline.ToShortDateString();
            labelIncidentType.Text = ((Ticket)clickedTicket.Tag).TypeOfIncident.ToString();
            labelPriority.Text = ((Ticket)clickedTicket.Tag).TicketPriority.ToString();
            labelStateName.Text = ((Ticket)clickedTicket.Tag).TicketState.ToString();           
        }

        private void buttonIncidentAanmaken_Click(object sender, EventArgs e)
        {
            TicketAddingForm form = new TicketAddingForm(this.user);
            
            this.Hide();            
            form.ShowDialog();
            this.Close();
        }

        private void buttonHighPriority_Click(object sender, EventArgs e)
        {
            var sort = Builders<BsonDocument>.Sort.Descending("TicketPriorityId");
        }




        //onnodig
        private void updateListView()
        {
            foreach (Ticket ticket in user.Tickets)
            {
                listViewTicketOverview.Items.Add(createListViewItem(ticket));
            }
        }

        private ListViewItem createListViewItem(Ticket ticket)
        {
            ListViewItem item = new ListViewItem();
            item.Tag = ticket;
            item.SubItems.Add(ticket.Title);
            item.SubItems.Add(ticket.TicketDate.OpeningDate.ToShortDateString());
            item.SubItems.Add(ticket.TicketPriority.ToString());
            item.SubItems.Add(ticket.TicketState.ToString());
            return item;
        }
    }
}
