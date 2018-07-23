using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Reverse Array or Strings");
            Console.Write("Please choose: ");
            var userValue = Console.ReadLine();

            string message = (userValue == "Strings") ? "Enter String: ": "Enter Array: ";
            Console.Write(message);
            var newValue = Console.ReadLine();
            if (userValue == "Strings")
            {
                string mama = ReverseString(newValue);
            }
            else PrintReverse(newValue);
            //PrintReverse();
            //Console.WriteLine();
            Console.ReadLine();
        }

        public static void PrintReverse(string greenMarker)
        {

            int[] array1 = { 1, 2, 3, 4, 5 };

            for (int x = 4; x < array1.Length && x != -1; x--)
            {
                int tmp;
                tmp = array1[x];
                Console.Write("{0} ", tmp);
            }
        }

        public static string ReverseString(string message)
        {
            string zig = message;
            string zigReverse = "";

            for(int i = zig.Length-1; i>= 0 ; i-- )
            {
                zigReverse = zigReverse + zig[i];
            }
            Console.WriteLine("Original String: " + zig);
            Console.WriteLine("Reverse String: " + zigReverse);
            return zigReverse;
        }
    }
}
