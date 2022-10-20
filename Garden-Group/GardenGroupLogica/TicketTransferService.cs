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
        private TicketService ticketService;
        private UserService userService;

        public TicketTransferService()
        {
            ticketService = new TicketService();
            userService = new UserService();
        }

        public void TransferTicket(string ticketId, string newServiceDeskEmployeeId)
        {
             
        }
    }
}
