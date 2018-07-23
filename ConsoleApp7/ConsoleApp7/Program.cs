using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game ");

             Console.Write("What is your first name: ");
             string firstName = Console.ReadLine();

             Console.Write("What is your last name: ");
             string lastName = Console.ReadLine();

             Console.Write("What city were you born in: ");
             string cityName = Console.ReadLine();


            /*
             char[] lastNameArray = lastName.ToCharArray();
             Array.Reverse(lastNameArray);

             char[] cityNameArray = cityName.ToCharArray();
             Array.Reverse(cityNameArray);

             string result = "";



             foreach (char item in lastNameArray)
             {
                 result += item;
             }
             result += " ";

             foreach (char item in cityNameArray)
             {
                 result += item;

             }
             */

            Console.Write("Results: "); 
            ReverseString(firstName);
            ReverseString(lastName);
            ReverseString(cityName);
            Console.ReadLine();
        }

        private static void ReverseString(string message)
        {

            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);

            foreach (char item in messageArray)
            {
                Console.Write(item);
            }
            Console.Write(" ");
        }
    }
}
