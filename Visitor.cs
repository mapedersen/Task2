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

        public Visitor()
        {
            _age = InputAge();
        }

        private int InputAge() 
        {
            Write("What is your age?: ");
            _age = int.Parse(ReadLine());
            return _age;
        }

        public int TicketPrice()
        {
            Ticket ticket = new Ticket(_age);
            return ticket.TicketPrice();
        }
    }
}
