using System;

namespace Bus_Trip_Challenge_Question
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bus challenge question

            Console.WriteLine("Would you like a medium or a large bus?");

            string busType = Console.ReadLine();

            Console.WriteLine("How many pupils on your bus trip?");

            int pupilNumber = Int32.Parse(Console.ReadLine());

            int teacherNumber = (pupilNumber / 10) + 1;

            int totalNumber = pupilNumber + teacherNumber;

            Console.WriteLine("The total number of pupils and teachers on your trip is " + totalNumber);

            int busCapacity;

            if (busType == "med")
            {
                busCapacity = 30;
            }
            else
            {
                busCapacity = 60;
            }

            int busNumber = totalNumber / busCapacity;

            if (totalNumber % busCapacity == 0)
            {
                busNumber = totalNumber / busCapacity;
            }
            else
            {
                busNumber = totalNumber / busCapacity + 1;


                Console.WriteLine("You need " + busNumber + " " + busType + " buses.");
            }
        }
    }
}

