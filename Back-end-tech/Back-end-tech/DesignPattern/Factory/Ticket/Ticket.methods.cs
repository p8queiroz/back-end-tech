﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Back_end_tech.DesignPattern.Factory.Ticket
{
    public partial class Ticket
    {
        public static Ticket Create(int id, string description, Status status, decimal value)
        {
            var ticket = new Ticket(id, description, status, value);
            return ticket;
        }

        public Status GetStatus(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public decimal GetValue(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public List<Ticket> NotCanceled(List<Ticket> tickets)
        {
            throw new NotImplementedException();
        }
    }
}
