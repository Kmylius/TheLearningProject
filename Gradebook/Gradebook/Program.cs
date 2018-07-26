using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Grades book = new Grades();
            book.AddGrade(91f);
            book.AddGrade(89.5f);
            book.AddGrade(75f);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("The average grade is " + stats.AverageGrade);
            Console.WriteLine("The highest grade is " + stats.HighestGrade);
            Console.WriteLine("The lowest grade is " + stats.LowestGrade);
            Console.ReadLine();
        }
    }
}
