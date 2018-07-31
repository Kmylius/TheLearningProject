using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    class Grades
    {
        public Grades()
        {
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }

        }

        public void WriteGrades(TextWriter textWriter)
        {
            textWriter.WriteLine("Grades");

            int i = 0;
            while (i < grades.Count)
            {
                textWriter.WriteLine(grades[i]);
                i++;
            }

            textWriter.WriteLine("***********");
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            float sum = 0f;


            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            stats.AverageGrade= sum/grades.Count();
            return stats;
        }


        List<float> grades;
    }
}
