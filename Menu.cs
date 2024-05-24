using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task2
{
    internal class Menu
    {
        private TextProcessor textProcessor;
        private Cinema cinema;


        public void Display()
        {
            Title = "Task2 - Lexicon";
            bool exit = false;
            while (!exit)
            {
                WriteLine("\n0. Exit Program");
                WriteLine("1. Go to the cinema as a single visitor");
                WriteLine("2. Go to the cinema as a group - multiple visitors");
                WriteLine("3. Repeat Text 10 times");
                WriteLine("4. Take the third word out of a sentence");
                Write("\nChoice: ");

                int option = int.Parse(Console.ReadLine());

                switch (option) {
                    case 0:
                        exit = true;
                        break;
                    case 1:
                        SingleVisitor();
                        break;
                    case 2:
                        MultipleVisitors();
                        break;
                    case 3:
                        RepeatText();
                        break;
                    case 4:
                        ExtractThirdWord();
                        break;
                    default:
                        WriteLine("Invalid option, try again");
                        break;
                }
            }
        }

        private void SingleVisitor()
        {
            cinema = new Cinema();
            cinema.SingleVisitor();
        }

        private void MultipleVisitors()
        {
            cinema = new Cinema();
            cinema.MultipleVisitors();
        }

        private void RepeatText()
        {
            TextProcessor textProcessor = new TextProcessor();
            textProcessor.RepeatText();
        }

        private void ExtractThirdWord()
        {
            textProcessor.ExtractThirdWord();
        }
    }
}
