using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Visitor
    {
        private int _age;

        public Visitor()
        {
            _age = RetrieveAge();
        }

        private int RetrieveAge() 
        {
            Console.Write("What is your age?: ");
            string input = Console.ReadLine();
            bool isParsedSuccesssfully = Int32.TryParse(input, out _age);
            return _age;
        }
        public void PrintAge()
        {
            Console.WriteLine(_age);
        }
    }
}
