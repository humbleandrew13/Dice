using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_FromBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Random die = new Random();
            
            Console.WriteLine("Please enter the number of dice you wish to roll:\n");
            int dice = int.Parse(Console.ReadLine());
            int sum = 0;

            Console.WriteLine();

            for (int i = 1; i <= dice; i++)
            {
                int dieRoll = die.Next(1, 7);
                Console.WriteLine("die {0}: {1}", i, dieRoll);
                sum += dieRoll;
            }
            Console.WriteLine("\nTotal of the dice: {0}\n", sum);
        }
    }
}
