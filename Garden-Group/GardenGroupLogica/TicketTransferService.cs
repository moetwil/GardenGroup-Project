using GardenGroupDAL;
using GardenGroupModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupLogica
{
    // Deze class is gemaakt als onderdeel 'O' van de Rubics door Lars Hartendorp. 
    public class TicketTransferService
    {
        private TicketDao ticketDao;
        public TicketTransferService()
        {
            this.ticketDao = new TicketDao();
        }
        public void TransferTicket(Ticket ticket, User newServiceDeskEmployee)
        {
            ticket.ServiceDeskEmployeeId = newServiceDeskEmployee.Id;
            this.ticketDao.UpdateTicket(ticket);
        }
    }
}
