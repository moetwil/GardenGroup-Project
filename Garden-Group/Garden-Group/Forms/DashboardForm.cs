using Garden_Group.UserControls;
using GardenGroupLogica;
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
{
    /*
    TODO:
    - Load all tickets
     */
    public partial class DashboardForm : Form
    {
        private User user;
        private TicketService ticketService;
        public DashboardForm(User user)
        {
            this.user = user;
            InitializeComponent();
            Test();
            this.Controls.Add(new MenuStripUC(this.user, this));
            this.SetSizeToDesktop();

            // Load service objects
            this.ticketService = new TicketService();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // Set welcome text to user
            this.labelWelcomeText.Text = $"Welkom {user.FirstName} {user.LastName}";

            //SetProgressBar(0, 0, this.circularPBUnresolvedIncidents);

            // Load the two PieCharts
            LoadPieCharts(this.user);
            
        }

        private void Test()
        {
            /*TicketService ticketService = new TicketService();
            Ticket ticket = ticketService.GetAllTickets()[0];
            MessageBox.Show(ticket.Title);*/

        }

        private void LoadPieCharts(User user)
        {
            switch (user.JobInfo.Role)
            {
                case Role.Employee:
                    LoadEmployeeCharts();
                    break;
                case Role.ServiceDeskEmployee:
                    LoadServiceEmployeeCharts();
                    break;
            }

        }


        private void LoadEmployeeCharts()
        {
            int amountOpenTickets = ticketService.GetOpenTicketsAmount(this.user.Tickets);
            int amountPastDeadlineTickets = ticketService.GetTicketsPastDeadlineAmount(this.user.Tickets);

            SetProgressBar(amountOpenTickets, this.user.Tickets.Count, this.circularPBUnresolvedIncidents);
            SetProgressBar(amountPastDeadlineTickets, this.user.Tickets.Count, this.circularProgressBarPastDeadline);
        }

        private void LoadServiceEmployeeCharts()
        {
            List<Ticket> allTickets = ticketService.GetAllTickets();
            int amountOpenTickets = ticketService.GetOpenTicketsAmount(allTickets);
            int amountPastDeadlineTickets = ticketService.GetTicketsPastDeadlineAmount(allTickets);

            SetProgressBar(amountOpenTickets, allTickets.Count, this.circularPBUnresolvedIncidents);
            SetProgressBar(amountPastDeadlineTickets, allTickets.Count, this.circularProgressBarPastDeadline);
        }

        private void SetProgressBar(int value, int max, CircularProgressBar.CircularProgressBar progressBar)
        {
            progressBar.Maximum = max;
            progressBar.Value = value;
            progressBar.Text = $"{value}/{max}";

            progressBar.Update();

        }


    }
}
