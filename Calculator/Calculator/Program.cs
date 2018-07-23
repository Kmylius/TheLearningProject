using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

       private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Calculator: Please choose a function");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Subtraction");
            Console.WriteLine("3) Multiplication");
            Console.WriteLine("4) Division");
            Console.WriteLine("5) Exit");
            string result = Console.ReadLine();

            if (result == "1")
            {
                Addition();
                return true;
            }
            else if (result == "2")
            {
                Subtraction();
                return true;
            }
            else if (result == "3")
            {
                Multiplication();
                return true;
            }
            else if (result == "4")
            {
                Division();
                return true;
            }
            else if (result == "5")
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public static string Addition(string one, string two)
        {
            int iOne = 0;
            int iTwo = 0;
            Console.Clear();
            Console.WriteLine("Welcome to the Addition Page!");
            Console.Write("Please write the first number you wish to add: ");
            string userInput1 = Console.ReadLine();
            Console.Write("Please write the second number you wish to add: ");
            string userInput2 = Console.ReadLine();

            Int32.TryParse(userInput1,out iOne);
            Int32.TryParse(userInput2, out iTwo);
            return (iOne + iTwo).ToString();


        }

        private static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Subtraction Page!");
            Console.Write("Please write the first number you wish to subtract: ");
            string userInput1 = Console.ReadLine();
            Console.Write("Please write the second number you wish to subtract: ");
            string userInput2 = Console.ReadLine();
        }

        private static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Multiplication Page!");
            Console.Write("Please write the number you wish to multiply: ");
            string userInput1 = Console.ReadLine();
            Console.Write("Please write the second number you wish to multiply: ");
            string userInput2 = Console.ReadLine();
        }

        private static void Division()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Division Page!");
            Console.Write("Please write the first number you wish to divide: ");
            string userInput1 = Console.ReadLine();
            Console.Write("Please write the second number you wish to divide: ");
            string userInupt2 = Console.ReadLine();
        }
    }
}
