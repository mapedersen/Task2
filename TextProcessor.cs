using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class TextProcessor
    {
        private string _textToRepeat;
        public void ExtractThirdWord()
        {
            Console.WriteLine("Please enter a sentence with at least three words:");
            string input = Console.ReadLine();

            // Split the input sentence into words
            string[] words = input.Split(' ');

            // Check if there are at least three words
            if (words.Length < 3)
            {
                Console.WriteLine("The sentence must contain at least three words.");
            }
            else
            {
                // Extract and display the third word
                string thirdWord = words[2];
                Console.WriteLine($"The third word is: {thirdWord}");
            }
        }

        public void RepeatText()
        {
            Console.Write("What is the text that you want to repeat 10 times?: ");
            _textToRepeat = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(_textToRepeat + ", ");
            }
            Console.WriteLine("\n");
        }
    }
}
