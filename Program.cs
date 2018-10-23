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
            double total = 0;
            int count = 0;

            //Repeatedly prompt the user for numbers. 
            while (true)
            {
                Console.Write("Enter a number or type \"done\" to see the average: ");
                string entry = Console.ReadLine();
                if (entry.ToLower() == "done")
                {
                    break;
                }
                try
                {
                    int number = int.Parse(entry);

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
