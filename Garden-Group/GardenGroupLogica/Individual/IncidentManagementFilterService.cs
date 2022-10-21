using GardenGroupModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GardenGroupLogica.Individual
{
    public static class IncidentManagementFilterService
    {
        public static List<Ticket> FilterTickets(List<Ticket> allTickets, string filter)
        {
            // split the filter string into words
            List<string> keyWords = filter.Split(' ').ToList();

            // remove last word if it is empty
            if (keyWords[keyWords.Count - 1] == "")
                keyWords.RemoveAt(keyWords.Count - 1);

            // transform all keywords to lowercase
            keyWords = keyWords.Select(x => x.ToLower()).ToList();

            // filter list of tickets on title and description with keywords array
            List<Ticket> filteredTickets = allTickets.Where(ticket =>
                 keyWords.Any(keyWord =>
                     ticket.Title.ToLower().Contains(keyWord) ||
                     ticket.Description.ToLower().Contains(keyWord))
             ).ToList();

            return filteredTickets;
        }
    }
}
