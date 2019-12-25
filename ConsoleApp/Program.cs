using System;
using ConsoleUtilities;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            string stringOutputText = "Hello world";
            utilities.writeline(stringOutputText);
            Console.ReadKey();
        }
    }
}
