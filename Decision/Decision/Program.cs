using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = "";
            if (userValue == "1")
                message = " You won a new car!";
            else if (userValue == "2")
                message = " You wom R100 000";
            else if (userValue == "3")
                message = "You lost";
            else
                message = "Sorry we did not understand!";
            Console.WriteLine(message);
            Console.ReadLine();


            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue2 = Console.ReadLine();

            string message2 = (userValue2 == "1") ? "boat" : "strand of lint";

            Console.Write("You won a ");
            Console.Write(message2);
            Console.Write(".");
            Console.ReadLine();
            Console.WriteLine("You won a {0}", message2);
            Console.ReadLine();
        }
    }
}
