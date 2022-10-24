using GardenGroupDAL;
using GardenGroupModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupLogica.Individual
{
    public  class IncidentManagementSearchService
    {

        // Get tickets with based on the entered search string
        public  List<Ticket> FindTicketsBySearchKeywords(string searchKeywords)
        {
            // split the filter string into words
            List<string> searchKeywordsList = SplitKeywords(searchKeywords);
            return SearchTickets(searchKeywordsList);
        }
        
        // create search filter
        private  List<Ticket> SearchTickets(List<string> searchKeywordsList)
        {
            Func<Ticket, bool> filter =
               (data) => searchKeywordsList.Any(keyword => data.Title.ToLower().Contains(keyword) || data.Description.ToLower().Contains(keyword));

            // get all tickets with the filter

            List<Ticket> tickets = new TicketDao().FindTicketsBySearchKeywords(filter);

            // sorteer tickets van nieuw -> oud
            tickets = tickets.OrderBy(ticket => ticket.TicketDate.OpeningDate).ToList();

            return tickets;
        }


        private  List<string> SplitKeywords(string searchKeywords)
        {
            // split searchkeywords in List
            List<string> searchKeywordsList = searchKeywords.Split(' ').ToList();

            // transform all searchkeywords to lowercase
            searchKeywordsList = searchKeywordsList.Select(x => x.ToLower()).ToList();

            // remove last word if it is empty
            if (searchKeywordsList[searchKeywordsList.Count - 1] == "")
                searchKeywordsList.RemoveAt(searchKeywordsList.Count - 1);

            return searchKeywordsList;
        }
    }
}
