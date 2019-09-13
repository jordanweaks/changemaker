using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace changeMaker
{
    class Program
    {
        static void Main(string[] args)
        {   //prompt user for change input
            Console.WriteLine("change: ");
            try
            {
                //convert user input to int
                int change = int.Parse(Console.ReadLine());
                //declare change variables
                int quarter = 25;
                int dime = 10;
                int nickel = 5;
                int pennies = 1;
                //change breakdown - take change and divide by quarters first, whats left over is divided by dimes, etc.
                int q = (change / quarter);
                int d = ((change % quarter) / dime);
                int n = (((change % quarter) % dime) / nickel);
                int p = ((((change % quarter) % dime) % nickel) / pennies);
                //display how much change should be given 



                if (q > 0)
                {
                    Console.WriteLine("Quarters: " + q);
                }
                if (d > 0)
                {
                    Console.WriteLine("Dimes: " + d);
                }
                if (n > 0)
                {
                    Console.WriteLine("Nickel: " + n);
                }
                if (p > 0)
                {
                    Console.WriteLine("Pennies: " + p);
                }
                if (change == 0)
                {
                    Console.WriteLine("no change");
                }
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Please enter only numbers");
            }
            





        }
    }
}


                        
        
