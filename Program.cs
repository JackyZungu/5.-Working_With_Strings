using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Working_With_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will write line");
            Console.WriteLine("This will \n wrap to next line");
            Console.WriteLine("This will \" print out the qoutation mark.");

            string firstName = "Jacky";
            string LastName = "Zungu";

            Console.WriteLine(LastName.Length);
            Console.WriteLine(firstName.ToUpper());
            Console.WriteLine (LastName.Contains("Zu"));
            Console.WriteLine(firstName[0]);
            Console.WriteLine("index of a is ");
            Console.WriteLine(LastName.IndexOf('a'));
            Console.WriteLine(firstName.Substring(1));
            Console.WriteLine(firstName.Substring(1, 2));

            Console.ReadLine(); 


        }
    }
}
