using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, what is your name?");
            Console.Write("Type your first name: ");
            string myFirstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName +" " + myLastName+ "! I am a robot. I am your friend!");
            Console.ReadLine();

        }
    }
}
