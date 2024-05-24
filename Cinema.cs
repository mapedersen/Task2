using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task2
{
    class Cinema
    {
        private Visitor _visitor;
        private Ticket _ticket;
        private List<Visitor> _visitors;
        private int _totalPrice;
        private int _amountOfVisitors;

        public void SingleVisitor()
        {
            WriteLine(Messages.GreetVisitor());
            Visitor _visitor = new Visitor(_amountOfVisitors);
            _visitor.TicketPrice();
        }

        public void MultipleVisitors()
        {
            _visitors = new List<Visitor>();
            WriteLine(Messages.GreetVisitor());
            Write("How many visitors are going?: ");
            _amountOfVisitors = int.Parse(Console.ReadLine());
            for (int i = 0; i < _amountOfVisitors; i++)
            {
                Visitor _visitor = new Visitor(_amountOfVisitors);
                _visitor.TicketPrice();
                _visitors.Add(_visitor);
            }
            TotalPrice();
        }

        public void TotalPrice()
        {
            foreach (var visitor in _visitors)
            {
                _totalPrice += visitor.ticketPrice;
            }
            WriteLine("The total price is: {0}kr", _totalPrice);
        }
    }
}
