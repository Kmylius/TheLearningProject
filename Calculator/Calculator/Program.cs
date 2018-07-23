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
            Console.WriteLine("");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Subtraction");
            Console.WriteLine("3) Multiplication");
            Console.WriteLine("4) Division");
            Console.WriteLine("5) Exit");
            Console.WriteLine("");
            string result = Console.ReadLine();

            switch (result)
            {
                case "1":
                Addition();
                return true;

                case "2":
                Subtraction();
                return true;

                case "3":
                Multiplication();
                return true;

                case "4":
                Division();
                return true;

                case "5":
                return false;

            }
            return false;

        }

        public static int Sum(int num1, int num2)
        {
            int total;
            total = num1 + num2;
            return total;
        }

        public static void Addition()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Addition Page!");
            Console.WriteLine("");
            Console.Write("Please write the first number you wish to add: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please write the second number you wish to add: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The total is : {0}", Sum(n1, n2));
            Console.ReadLine();


        }

        public static int Sum2(int num1, int num2)
        {
            int total;
            total = num1 - num2;
            return total;
        }
        private static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Subtraction Page!");
            Console.WriteLine("");
            Console.Write("Please write the first number you wish to subtract: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please write the second number you wish to subtract: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The total is : {0}", Sum2(n1, n2));
            Console.ReadLine();
        }


        public static int Sum3(int num1, int num2)
        {
            int total;
            total = num1 * num2;
            return total;
        }
        private static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Multiplication Page!");
            Console.WriteLine("");
            Console.Write("Please write the number you wish to multiply: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please write the second number you wish to multiply: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The total is : {0}", Sum3(n1, n2));
            Console.ReadLine();
        }


        private static int Sum4(int num1, int num2)
        {
            int total;
            total = num1 / num2;
            return total;
        }
        private static void Division()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Division Page!");
            Console.WriteLine("");
            Console.Write("Please write the first number you wish to divide: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please write the second number you wish to divide: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The total is : {0}", Sum4(n1, n2));
            Console.ReadLine();
        }
    }
}
