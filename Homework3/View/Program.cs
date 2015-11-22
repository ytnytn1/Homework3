using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfNumber;
            while (true)
            {
                ConsoleKeyInfo key = new ConsoleKeyInfo();
                Console.Clear();
                Console.WriteLine("Enter the amount of Number");
                var value = (Console.ReadLine());
                if (Int32.TryParse(value, out amountOfNumber) && amountOfNumber > 0)
                {
                    break;
                }
                else
                {
                    while (key.Key != ConsoleKey.Enter)
                    {
                        Console.WriteLine("Error wrong value, press enter co continue");
                        key = Console.ReadKey(true);
                        //Console.Clear();
                    }
                }
            }
            Console.Clear();
            var rnd = new Random();

            var numbertron = new Numbertron();

            var jay = new Jay();

            var silentbob = new SilentBob();

            numbertron.NewNumber += jay.FetchNewNumber;
            numbertron.NewNumber += silentbob.FetchNewNumber;

            for (int i = 0; i < amountOfNumber; i++)
            {
                numbertron.Generate(rnd);
            }

            if(jay.Score > silentbob.Score)
                Console.WriteLine("{0} is a winner",jay.Name);
            else if (jay.Score < silentbob.Score)
                Console.WriteLine("{0} is a winner", silentbob.Name);
            else 
                Console.WriteLine("Draw");
            Console.ReadKey();
            
        }
        
    }
}
