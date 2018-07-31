using System;
using System.Collections.Generic;
using System.IO;
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
            FileStream stream = null;
            StreamReader reader = null;

            try
            {
                stream = File.Open("grades.txt", FileMode.Open);
                reader = new StreamReader(stream);

                string line = reader.ReadLine();
                while(line != null)
                {
                    float grade = float.Parse(line);
                    book.AddGrade(grade);
                    line = reader.ReadLine();
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Could not locate the file grades.txt");
                return;
            }
            catch(UnauthorizedAccessException ex)
            {
                Console.WriteLine("Context restricted");
                return;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (stream != null)
                {
                    stream.Close();
                }

            }
            book.AddGrade(91f);
            book.AddGrade(89.5f);
            book.AddGrade(75f);
            book.WriteGrades(Console.Out);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("The average grade is " + stats.AverageGrade);
            Console.WriteLine("The highest grade is " + stats.HighestGrade);
            Console.WriteLine("The lowest grade is " + stats.LowestGrade);
            Console.WriteLine("{0} {1}", stats.LetterGrade,stats.Description);
            Console.ReadLine();
        }
    }
}
