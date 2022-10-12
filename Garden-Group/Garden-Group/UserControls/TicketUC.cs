using Garden_Group.Forms;
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
    public partial class TicketUC : UserControl
    {
        private Ticket ticket;
        private TicketOverviewForm parent;
        public TicketUC(Ticket ticket, TicketOverviewForm parent)
        {
            this.parent = parent;
            this.ticket = ticket;
            this.MinimumSize = new Size(450 - SystemInformation.VerticalScrollBarWidth, 70);
            InitializeComponent();
            this.Tag = ticket;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelTicketState.Visible = true;
            FillUC();
            this.Load += Items_Load;
        }
        private void Items_Load(object sender, EventArgs e)
        {
            this.MouseClick += Control_MouseClick;
            foreach (Control control in Controls)
            {
                control.MouseClick += Control_MouseClick;
            }
        }
        private void Control_MouseClick(object sender, MouseEventArgs e)
        {
            var wasClicked = WasClicked;
            if (wasClicked != null)
            {
                WasClicked(this, EventArgs.Empty);
            }
        } 
        public event EventHandler<EventArgs> WasClicked;
        public void FillUC()
        {
            labelTitle.Text = ticket.Title;
            labelDescription.Text = ticket.Description;
            labelTicketDateStart.Text = ticket.TicketDate.OpeningDate.Date.ToShortDateString();
            labelTicketDateEnd.Text = ticket.TicketDate.ClosingDate.ToShortDateString();

            if (ticket.TicketState.Name is not null)
                labelTicketState.Text += ticket.TicketState.Name;
            else
                labelTicketState.Text += "No ticket state";

            switch(ticket.TicketPriority.PriorityLevel)
            {
                case "Low":
                    panelTicketState.BackColor = Color.Green;
                    break;
                case "Normal":
                    panelTicketState.BackColor = Color.Orange;
                    break;
                case "High":
                    panelTicketState.BackColor = Color.Red;
                    break;
                default:
                    panelTicketState.BackColor = Color.SlateGray;
                    break;
            }

        }
        //parent.ticketConrtol_Click(sender, e); 
        public void TicketUC_Click(object sender, EventArgs e)
        {
            
        }
    }
}
