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
        private int _amountOfVisitors;

        public int SingleVisitorAge()
        {
            Write("What is your age?: ");
            return _age = int.Parse(ReadLine());
        }

        public int GetNumberOfVisitors()
        {
            Write("How many visitors are going?: ");
            return int.Parse(ReadLine());
        }
        public List<int> GetAgesForMultipleVisitors(int numberOfVisitors)
        {
           List<int> ages = new List<int>();
            for (int i = 0; i < numberOfVisitors; i++)
            {
                WriteLine($"What is the age of visitor {i + 1}?: ");
                ages.Add(int.Parse(ReadLine()));
            }
            return ages;
        }
    }
}
