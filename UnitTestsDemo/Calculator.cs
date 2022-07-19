using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsDemo
{
    public class Calculator
    {
        public double CalculateAverage(double a, double b)
        {
            return (a >= 0 && b >= 0 ? (a + b) / 2 : 
                throw new ArgumentException("All argument values ​​must be greater than or equal to 0"));

        }

        public double CalculateSum(double a, double b)
        {
            return (a + b);
        }
        public double CalculateMarksAverage(Student student)
        {
            if (student.Marks != null && student.Marks.Any())
            {
                return student.Marks.Average();
            }
            throw new ArgumentException("Marks cannot be null or empty");
        }
    }
}
