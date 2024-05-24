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
            // Sätter titel på konsolen
            Title = "Task2 - Lexicon";

            // Creating a menu that displays until exit is chosen
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

        // Initiating an instance of cinema and calls the method that handles a single visitor
        private void SingleVisitor()
        {
            cinema = new Cinema();
            cinema.SingleVisitor();
        }

        // Initiating an instance of cinema and calls the method that handles multiple visitors
        private void MultipleVisitors()
        {
            cinema = new Cinema();
            cinema.MultipleVisitors();
        }

        // Initiating an instance of the TextProcessor and calls the method that Repeats the users input on a single line
        private void RepeatText()
        {
            TextProcessor textProcessor = new TextProcessor();
            textProcessor.RepeatText();
        }

        // Initiating an instance of the TextProcessor and calls the method that extracts the third word from a sentence
        private void ExtractThirdWord()
        {
            TextProcessor textProcessor = new TextProcessor();
            textProcessor.ExtractThirdWord();
        }
    }
}
