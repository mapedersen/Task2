using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task2
{
    internal class Visitor
    {
        private int _age;
        private Ticket _ticket;
        public int ticketPrice;

        public Visitor(VisitorInput input, int amountOfVisitors)
        {
            _age = input.SetAge(amountOfVisitors);
        }

        public void TicketPrice()
        {
            Ticket ticket = new Ticket(_age);
            ticketPrice = ticket.TicketPrice();
        }
    }
}
