using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bmi1 = CalculateBMI(70, 1.75);
            Console.WriteLine($"BMI (metric, default): {bmi1}");

            double bmi2 = CalculateBMI(height: 1.80, weight: 85);
            Console.WriteLine($"BMI (metric, named args): {bmi2}");

            double
        }
    }
}
