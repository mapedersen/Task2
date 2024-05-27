using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Ticket
    {
        public int Age { get; private set; }
        public int Price { get; private set; }
        public string TicketType { get; private set; }
        public Ticket(int age)
        {
            Age = age;
            TicketPrice();
        }

        public int TicketPrice()
        {
            if (Age < 20)
            {
                Price = 80;
                TicketType = "Youth";
            }
            else if (Age > 64)
            {
                Price = 90;
                TicketType = "Ordinary";
            }
            else
            {
                Price = 120;
                TicketType = "Senior";
            }
            return Price;
        }

    }
}
