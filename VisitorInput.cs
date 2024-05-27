using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task2
{
    public class VisitorInput
    {
        private int _age;
        public int SetAge(int amountOfVisitors)
        {
            if (amountOfVisitors == 0)
            {
                _age = SingleVisitorAge();
            }
            else if (amountOfVisitors > 1)
            {
                _age = MultipleVisitorsAge();
            }
            return _age;
        }

        public int SingleVisitorAge()
        {
            Write("What is your age?: ");
            _age = int.Parse(ReadLine());
            return _age;
        }

        public int MultipleVisitorsAge()
        {
            Write("What is the age of the visitor?: ");
            _age = int.Parse(ReadLine());
            return _age;
        }
    }
}
