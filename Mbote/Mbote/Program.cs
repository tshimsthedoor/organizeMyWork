using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mbote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World.");
            Console.ReadLine();
            // Declare two integers variables
            int x;
            int y;
            /* Here y is taking 
             * the value of x
             * + 3 */

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();

            Console.WriteLine("What is your name?");
            Console.Write("Type your name: ");
          
          string  myFisrtName = Console.ReadLine();

          
            Console.Write("Type your last name: ");
          string  myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " +myFisrtName+ " " +myLastName);
            Console.ReadLine();
        }
    }
}
