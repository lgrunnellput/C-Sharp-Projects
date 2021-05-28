using System;

namespace BMI_Task
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your height in inches:");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your weight in pounds:");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Your bmi is:" +);
            Console.ReadLine();

        }//end of main


        public static double convertToMeters(double inches)
        {
            double meters;

            meters = (inches * 2.54) / 100;

            return meters;

        }

        public static double convertToKg(double pounds)
        {
            double kg;

            kg = pounds / 2.2;

            return kg;
        }

        public static double calcBMI(double weight, double height)
        { 
            double bmi;

            bmi = weight / (height * height);

            return bmi;

        }
    }
}
