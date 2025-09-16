using System;
using System.CodeDom;
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
            Console.WriteLine($"BMI (metric, default): {bmi1:F2}");

            double bmi2 = CalculateBMI(height: 1.80, weight: 85);
            Console.WriteLine($"BMI (metric, named args): {bmi2:F2}");

            double bmi3 = CalculateBMI(unit: "imperial", weight: 180, height: 70);
            Console.WriteLine($"BMI (imperial): {bmi3:F2}");

            double bmi4 = CalculateBMI(70, 1.75, "unknown");
            Console.WriteLine($"BMI (unknown unit): {bmi4:F2}");

            Console.ReadLine();
        }
       
       static double CalculateBMI(double weight, double height, string unit = "metric")

        {
            if (unit == "metric")
            {

                return weight / (height * height);
            }
            else if ( unit == "imerpial")
            {
                return 703 * weight / (height * height));

            }
            else
            {
             Console.WriteLine("Unknown unit, returning 0 ");
                return 0;
            }
        }
    }
}
