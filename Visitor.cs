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

        public Visitor(int amount)
        {
            if (amount == 0)
            {
            _age = SingleVisitorAge();
            }
            else if (amount > 1)
            {
                _age = MultipleVisitorsAge();
            }
        }

        private int SingleVisitorAge() 
        {
            Write("What is your age?: ");
            _age = int.Parse(ReadLine());
            return _age;
        }

        private int MultipleVisitorsAge()
        {
            Write("What is the age of the visitor?: ");
            _age = int.Parse(ReadLine());
            return _age;
        }

        public void TicketPrice()
        {
            Ticket ticket = new Ticket(_age);
            ticketPrice = ticket.TicketPrice();
        }
    }
}
