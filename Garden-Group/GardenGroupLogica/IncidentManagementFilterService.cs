using GardenGroupModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GardenGroupLogica
{
    public static class IncidentManagementFilterService
    {
        public static List<Ticket> FilterTickets(List<Ticket> allTickets, string filter)
        {
            // Filter list of tickets on title and description
            List<Ticket> filteredTickets = allTickets.Where(ticket =>
            ticket.Title.ToLower().Contains(filter.ToLower()) ||
            ticket.Description.ToLower().Contains(filter.ToLower())
            ).ToList();

            return filteredTickets;
        }
    }
}
