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
        public int Age { get; }
        public Ticket Ticket { get; set; }

        public Visitor(int age)
        {
            Age = age;
            Ticket = new Ticket(age);
        }

    }
}
