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
            bool exit = false;
            while (!exit)
            {
                WriteLine("\n0. Exit Program");
                WriteLine("1. Go To Cinema");
                WriteLine("2. Repeat Text 10 times");
                WriteLine("3. Take the third word out of a sentence");
                Write("\nChoice: ");

                int option = int.Parse(Console.ReadLine());

                switch (option) {
                    case 0:
                        exit = true;
                        break;
                    case 1:
                        EnterCinema();
                        break;
                    case 2:
                        RepeatText();
                        break;
                    case 3:
                        ExtractThirdWord();
                        break;
                    default:
                        WriteLine("Invalid option, try again");
                        break;
                }
            }
        }

        private void EnterCinema()
        {
            cinema = new Cinema();
            cinema.Enter();
        }

        private void RepeatText()
        {
            textProcessor.RepeatText();
        }

        private void ExtractThirdWord()
        {
            textProcessor.ExtractThirdWord();
        }
    }
}
