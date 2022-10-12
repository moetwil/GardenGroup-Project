﻿using GardenGroupModel;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupDAL
{
    public class TicketDao : BaseDao
    {
        public IMongoCollection<Ticket> m_Collection { get; set; }


        public TicketDao()
        {
            m_Collection = this.m_Database.GetCollection<Ticket>("Tickets");
            
        }

        public Ticket FindTicketByTitle(string title)
        {
            return m_Collection.Find(ticket => ticket.Title == title).FirstOrDefault();
        }

        public void AddTicket(Ticket ticket)
        {
            m_Collection.InsertOne(ticket);
        }

        public List<Ticket> GetAllTickets()
        {
            return GetAllDocuments<Ticket>(this.m_Collection);
        }

        public List<Ticket> GetTicketsFromUser(User user)
        {
            return GetDocumentsByCreator<Ticket>(this.m_Collection, user);
        }

        public void DeleteTicket(Ticket ticket)
        {
            DeleteById<Ticket>(this.m_Collection, ticket.Id);
        }

        public void UpdateTicket(Ticket ticket)
        {
            UpdateDocument<Ticket>(this.m_Collection, ticket.Id, ticket);
        }        
    }
}

