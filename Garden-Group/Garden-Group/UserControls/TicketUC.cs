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
        public TicketUC(Ticket ticket, TicketOverviewForm parent)
        {
            this.ticket = ticket;
            this.Tag = ticket;
            InitializeComponent();
            FillUC();
            //this.Load += Items_Load;
        }
        //public TicketUC(Ticket ticket, TicketOverviewForm parent)
        //{
        //    this.parent = parent;
        //    this.ticket = ticket;
        //    InitializeComponent();
        //    this.Tag = ticket;
        //    this.AutoSize = true;
        //    this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        //    panelTicketState.Visible = true;
        //    FillUC();
        //    this.Load += Items_Load;
        //}
        //private void Items_Load(object sender, EventArgs e)
        //{
        //    this.MouseClick += Control_MouseClick;
        //    foreach (Control control in Controls)
        //    {
        //        control.MouseClick += Control_MouseClick;
        //    }
        //}
        //private void Control_MouseClick(object sender, MouseEventArgs e)
        //{
        //    var wasClicked = WasClicked;
        //    if (wasClicked != null)
        //    {
        //        WasClicked(this, EventArgs.Empty);
        //    }
        //}
        //public event EventHandler<EventArgs> WasClicked;

        public void FillUC()
        {
            labelTitle.Text = ticket.Title;
            labelTicketDateStart.Text = ticket.TicketDate.OpeningDate.ToShortDateString();
            labelPriorityLevel.Text = "Prioriteit " + ticket.TicketPriority.ToString();
            labelTicketState.Text = "Status " + ticket.TicketState.ToString();
        }

        public void TicketUC_Click(object sender, EventArgs e)
        {
            TicketOverviewForm form = (TicketOverviewForm)ParentForm;
            form.TicketUc_Click(this, e); 
        }
        //parent.ticketConrtol_Click(sender, e); 

    }
}
