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

        }

        public void RepeatText()
        {
            Console.Write("What is the text that you want to repeat 10 times?: ");
            _textToRepeat = Console.ReadLine();
            for (int i = 0; i < 11; i++)
            {
                Console.Write(_textToRepeat + ", ");
            }
            Console.WriteLine("\n");
        }
    }
}
