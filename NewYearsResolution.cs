using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace New_Year_s_Resolution_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Thank you " + firstName + ", please enter your surname:");
            string lastName = Console.ReadLine();

            string fullName = firstName + " " + lastName;
            
            Console.WriteLine("Welcome to the program " + fullName + ", please enter your New Year's Resolution:");
            string newResolution = Console.ReadLine();

            Console.WriteLine("Input has been logged.");


            using (StreamWriter file = new StreamWriter("resolutionInput.txt", true))
            {
                file.WriteLine(fullName + ", " + newResolution);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Console is checking values...");
            Console.WriteLine("\n");
            Console.WriteLine("Are all of these values correct? Type yes/no.");
            Console.WriteLine("\n");
            Console.WriteLine("Your first name is: " + firstName);
            Console.WriteLine("Your last name is: " + lastName);
            Console.WriteLine("Your New Year's Resolution is: " + newResolution);
            Console.WriteLine("\n");

            string userAnswer = Console.ReadLine();

            while (userAnswer == "no")
            {
                Console.Clear();
                Console.WriteLine("Type 1 to enter a new first name.");
                Console.WriteLine("Type 2 to enter a new last name.");
                Console.WriteLine("Type 3 to enter a another New Year's Resolution");
                Console.WriteLine("Type 4 to change the info into a new and nicer format.");

                int userChoice = Int32.Parse(Console.ReadLine());

                Console.ReadLine();

                if (userChoice == 1)
                {
                    Console.WriteLine("Please re-enter your first name:");
                    string firstName1 = Console.ReadLine();
                    Console.WriteLine("\n");
                    Console.WriteLine("Your first name has been changed to: " + firstName1);

                    using (StreamWriter file = new StreamWriter("resolutionInput.txt", true))
                    {
                        file.WriteLine("NEW VALUE:" + firstName1 + " " + lastName + ", " + newResolution);
                    }

                    Console.WriteLine("Are all of these values correct? Type yes/no.");

                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("Please re-enter your last name: ");
                    string lastName1 = Console.ReadLine();
                    Console.WriteLine("\n");
                    Console.WriteLine("Your last name has been changed to: " + lastName1);

                    using (StreamWriter file = new StreamWriter("resolutionInput.txt", true))
                    {
                        file.WriteLine("NEW VALUE:" + firstName + " " + lastName1 + ", " + newResolution);
                    }

                    Console.WriteLine("Are all of these values correct? Type yes/no.");

                }
                else if (userChoice == 3)
                {
                    Console.WriteLine("Please re-enter your New Year's Resolution: ");
                    string newResolution1 = Console.ReadLine();
                    Console.WriteLine("\n");
                    Console.WriteLine("Your new year's resolution has been changed to: " + newResolution1);

                    using (StreamWriter file = new StreamWriter("resolutionInput.txt", true))
                    {
                        file.WriteLine("NEW VALUE:" + firstName + " " + lastName + ", " + newResolution1);
                    }

                    Console.WriteLine("Are all of these values correct? Type yes/no.");
                }
                else if (userChoice ==4)
                {
                    //Not completed! (unsure)
                    Console.WriteLine("Changing the format..."); 
                }
            }
            

            Console.ReadLine();
        }
    }
}
