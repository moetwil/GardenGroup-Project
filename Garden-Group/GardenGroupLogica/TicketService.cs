using GardenGroupDAL;
using GardenGroupModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using GardenGroupModel.Enums;


namespace GardenGroupLogica
{
    public class TicketService
    {
        private TicketDao ticketDao;
        private UserService userService;

        public TicketService()
        {
            ticketDao = new TicketDao();
            userService = new UserService();
        }

        public Ticket FindTicketByTitle(string title)
        {
            return ticketDao.FindTicketByTitle(title);
        }

        public void AddTicket(Ticket ticket)
        {
            ticketDao.AddTicket(ticket);
        }

        public List<Ticket> GetAllTickets()
        {
            return ticketDao.GetAllTickets();
        }

        public List<Ticket> GetTicketsFromUser(User user)
        {
            return ticketDao.GetTicketsFromUser(user);
        }

        // Delete ticket
        public void DeleteTicket(Ticket ticket)
        {
            ticketDao.DeleteTicket(ticket);
        }

        // Update ticket
        public void UpdateTicket(Ticket ticket)
        {
            ticketDao.UpdateTicket(ticket);
        }

        public int GetOpenTicketsAmount(List<Ticket> tickets)
        {
            // Deze methode mss met aggregate?
            int amount = 0;
            foreach (Ticket ticket in tickets)
            {

                if (ticket.TicketState == TicketState.Open ||
                    ticket.TicketState == TicketState.InProgress)
                    amount++;
            }
            // Mischien beter maar aggregate is nog beter
            int amount2 = tickets.Where(ticket => ticket.TicketState == TicketState.Open || ticket.TicketState == TicketState.InProgress).Count();
            return amount;
        }

        public int GetTicketsPastDeadlineAmount(List<Ticket> tickets)
        {
            int amount = 0;
            foreach (Ticket ticket in tickets)
            {

                if (ticket.TicketDate.Deadline < DateTime.Now &&
                    (ticket.TicketState == TicketState.Open ||
                    ticket.TicketState == TicketState.InProgress))
                    amount++;
            }
            // Mischien beter maar aggregate is nog beter
            int amount2 = tickets.Where(ticket => ticket.TicketDate.Deadline < DateTime.Now && (ticket.TicketState == TicketState.Open || ticket.TicketState == TicketState.InProgress)).Count();
            return amount;
        }

    }
}

