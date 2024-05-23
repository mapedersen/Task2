using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Ticket
    {
        private int _age;
        private int _price;
        public Ticket(int age)
        {
            _age = age;
        }

        public int TicketPrice()
        {
            if (_age < 20)
            {
                _price = 80;
                Console.WriteLine(Messages.DisplayYouthPrice() + _price);
            }
            else if (_age > 64)
            {
                _price = 90;
                Console.WriteLine(Messages.DisplaySeniorPrice() + _price);
            }
            else
            {
                _price = 120;
                Console.WriteLine(Messages.DisplayOrdinaryPrice() + _price);
            }
            return _price;
        }

    }
}
