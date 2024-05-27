using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task2
{
    class PriceCalculator
    {
        public void DisplayTotalPrice(Visitor visitor)
        {
            WriteLine($"Ticket price for the visitor is {visitor.Ticket.Price}");
        }

        public void DisplayTotalPrice(List<Visitor> visitors) 
        { 
            int totalPrice = visitors.Sum(visitor => visitor.Ticket.Price);
            Console.WriteLine($"Total ticket price for {visitors.Count} visitors is {totalPrice}");
        }
    }
}
