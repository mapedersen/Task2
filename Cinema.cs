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
        
        public Cinema() 
        {
              
        }

        public void Enter()
        {
            WriteLine(Messages.GreetVisitor());
            Visitor _visitor = new Visitor();
            _visitor.TicketPrice();
        }
    }
}
