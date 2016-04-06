using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an English word:");

            string entry = Console.ReadLine();
            string translateToPig = "";
            string endingLetter = "";
            string entryWithoutFirstLetter = "";

            if (entry is string)
            {

                endingLetter = entry.Substring(0, 1);
                entryWithoutFirstLetter = entry.Substring(1);

                translateToPig = entryWithoutFirstLetter + endingLetter + "ay";

                Console.WriteLine(translateToPig);

            }
            else
            {
                Console.WriteLine("Try again. No numbers or special characters.");
            }
            Console.ReadLine();
        }
    }
}
