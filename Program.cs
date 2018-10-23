using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Averager
{
    class Program
    {
        static void Main(string[] args)
        {
            var total = 0.0;
            var count = 0;

            //Repeatedly prompt the user for numbers. 
            while (true)
            {
                Console.Write("Enter a number or type \"done\" to see the average: ");
                var entry = Console.ReadLine();
                if (entry.ToLower() == "done")
                {
                    break;
                }
                try
                {
                    var number = double.Parse(entry);

                    //Add all of the numbers together. 
                    total += number;
                    count += 1;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid entry.");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid entry.");
                    continue;
                }
            }

            //When the user types in “done”, 
            //print the average of all of the numbers by dividing the total by the number of numbers entered.
            double average = total / count;
            Console.WriteLine("Average: " + average);
            Console.ReadLine();
        }
    }
}
