using GardenGroupDAL;
using GardenGroupModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupLogica
{
    public class TicketTransferService
    {
        private TicketDao ticketDao;
        private TicketService ticketService;
        //private UserService userService;

        public TicketTransferService()
        {
            this.ticketDao = new TicketDao();
            ticketService = new TicketService();
           //userService = new UserService();
        }

        public void TransferTicket(Ticket ticket, User newServiceDeskEmployee)
        {
            ticket.ServiceDeskEmployeeId = newServiceDeskEmployee.Id;
            this.ticketDao.UpdateTicket(ticket);
        }
    }
}
