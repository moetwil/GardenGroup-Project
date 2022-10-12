using MongoDB.Driver;
using System.Configuration;
using System.Data;
using GardenGroupModel;
using MongoDB.Bson;
using GardenGroupDAL;
using GardenGroupLogica;
using Garden_Group.Forms;

namespace Garden_Group
{
    public partial class Form1 : Form
    {
        /*MongoClient m_Client;
        IMongoDatabase m_Database;
        IMongoCollection<User> m_Collection;*/

        public Form1()
        {
            InitializeComponent();
            this.SetSizeToDesktop();


            /*            // Add new User
                        User user = new User("test2");
                        user.LastName = "Moetwil";
                        userService.AddUser(user);
            */

            /*            //Add new User
                        User user2 = new User("test3");
                        user2.FirstName = "test3";
                        user2.LastName = "Moetwil";
                        user2.DateOfBirth = new DateTime(1990, 1, 1);
                        user2.ContactInfo = new ContactInfo();
                        user2.ContactInfo.Email = "info@info.nl";
                        user2.ContactInfo.PhoneNumber = "0612345678";
                        user2.ContactInfo.Address = new Address();
                        user2.ContactInfo.Address.Street = "Teststraat";
                        user2.JobInfo = new JobInfo();
                       // user2.JobInfo.Role = Role.Manager;
                        user2.JobInfo.Branch = new Branch();
                        user2.JobInfo.Branch.Name = "Test";
                        userService.AddUser(user2);
            */


            TicketService ticketService = new TicketService();




            /* //Add new Ticket
             Ticket ticket = new Ticket();
             ticket.Title = "Test1";
             ticket.Description = "Test";
             ticket.CreatorID = "63297c29641c20cbfc6b48d7";
             ticket.TicketSolvers.Add("63297c29641c20cbfc6b48d7");
             ticket.TicketDate = new TicketDate();
             ticket.TicketDate.OpeningDate = DateTime.Now;
             ticket.TicketDate.ClosingDate = DateTime.Now;
             ticket.TicketDate.Deadline = DateTime.Now;*/

            /*List<Ticket> allTickets = ticketService.GetAllTickets();

            allTickets[0].Title = "Test3";

            MessageBox.Show(allTickets[0].Id.ToString());

            ticketService.UpsertTicket(allTickets[0]);*/



            /*// Select user based on firstname
            User user = m_Collection.Find(user => user.FirstName.Equals("test")).FirstOrDefault();*/



        }

        private void buttonAddTicket_Click(object sender, EventArgs e)
        {
            // open TicketAddingForm
            /*TicketAddingForm ticketAddingForm = new TicketAddingForm(this.user);
            ticketAddingForm.Show();
            this.Hide();*/
        }

        /* void TestMethod(User user)
         {
             user.FirstName.Equals("test");
             return user;
         }*/
    }
}