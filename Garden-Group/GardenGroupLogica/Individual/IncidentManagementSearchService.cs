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

        public  List<Ticket> FindTicketsBySearchKeywords(string searchKeywords)
        {
            // split the filter string into words
            List<string> searchKeywordsList = SplitKeywords(searchKeywords);
            return SearchTickets(searchKeywordsList);



            //return m_Collection.AsQueryable().Where(wherePredicate).ToList();
        }
        
        // create search filter
        public  List<Ticket> SearchTickets(List<string> searchKeywordsList)
        {
            Func<Ticket, bool> filter =
               (data) => searchKeywordsList.Any(keyword => data.Title.ToLower().Contains(keyword) || data.Description.ToLower().Contains(keyword));

            return new TicketDao().FindTicketsBySearchKeywords(filter);
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
