using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace GUIDED_TASK___Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int userScore = 0;


            //Asking the user for the correct password to enter the game.
            Console.WriteLine("Hello and welcome to the game. Please enter the secret password to continue:");
            string userPasswordInput = Console.ReadLine();

            while (userPasswordInput == "thisPasswordIsSecure123")
            {
                Console.Clear();

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Welcome to the menu the game. Click an option to continue:"); //Displays the menu.

                Console.WriteLine("Option 1: Add your favourite pop song to the song list.");
                Console.WriteLine("Option 2: Read the instructions for the game.");
                Console.WriteLine("Option 3: Play the game.");
                Console.WriteLine("Option 4: Exit the program.");
                Console.WriteLine("Option 5: View the top 5 scorers!");



                int userMenuInput = Int32.Parse(Console.ReadLine());

                if (userMenuInput == 1)
                {
                    option1();
                }
                else if (userMenuInput == 2)
                {
                    option2();
                }
                else if (userMenuInput == 3)
                {

                    randomSongLineGenerator();

                    int valueTempScore = splitSongList();

                    userScore = userScore + valueTempScore;

                    Console.WriteLine("Your score is: " + userScore);

                    Console.ReadLine();

                }
                else if (userMenuInput == 4)
                {
                    Console.WriteLine("Your final score is: " + userScore);

                    Console.WriteLine("Please enter your name to log your score into the system. If you don't want to use your name, write anonymous user.");
                    string userName = Console.ReadLine();

                    using (StreamWriter file = new StreamWriter("playerNamesList.txt", true))
                    {
                        file.WriteLine(userName + ", " + userScore);
                    }

                    Console.ReadLine();

                    option4();
                }
                else if (userMenuInput == 5)
                {                  
                    option5(); //Prints the highest score.
                }
                else
                {
                    Console.WriteLine("Input is not a number, it is invalid.");
                    Console.ReadLine();
                }
            }



            //Password is incorrect.
            Console.WriteLine("Wrong password!");
            Console.ReadLine();
            System.Environment.Exit(0);



            //ADDING THE SETUP LIST OF SONGS TO THE FILE- WRITING TO THE FILE.
            //Declaring the variable (the user's song and artist input) and reading the value of the user song input.
            string userNewSong = Console.ReadLine();

            string[] songList = File.ReadAllLines("songArtistList.txt"); //Creates a string[].


        }

        public static void option1() //Option to add a song to the song list.
        {
            //Asks the user if they would like to add a song to the song list.
            Console.WriteLine("Option 1 was selected. Would you like to add one of your favourite songs to the song list of the game? yes/no");
            string userAddSong = Console.ReadLine();

            if (userAddSong == "yes")
            {
                //Inputs song list and artist name.
                Console.WriteLine("Type in the song you'd like to add to the song list:");
                string userSongChoice = Console.ReadLine(); //Console reads the song name.

                Console.WriteLine("Type in the artist of the song you chose:");
                string userSongChoiceArtist = Console.ReadLine(); //Console reads the artist's name.

                using (StreamWriter file = new StreamWriter("songArtistList.txt", true))
                {
                    file.WriteLine(userSongChoice + ", " + userSongChoiceArtist);
                    //Writes the song name and the artist's name to the file
                    //in the same format as the pre-loaded ones so it works with the split function.
                }

                Console.WriteLine("Input is logged. Returning to menu..."); //Written the new song to the file.
            }
            else if (userAddSong == "no")
            {
                //User says no.
                Console.WriteLine("Exiting to the menu...");
            }
            else
            {
                //Validates, important so program doesn't shut down because of an error.
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
        }

        public static void option2() //Option to display list of instructions.
        {




            Console.WriteLine("Would you like to read the instructions? yes/no"); //Confirming if they want to read the instructions.
            string userInstructionsChoice = Console.ReadLine();
            Console.Clear(); //Clears rest of console ready to read instructions.


            //List of instructions FUNCTION: (reads instructions)
            if (userInstructionsChoice == "yes")
            {
                string instruction1 = ("The aim of the game is to try and guess the correct famous pop song and the artist of the song.");

                string instruction2 = ("You only have two guesses!");

                string instruction3 = ("You get 5 points for guessing the song name and artist on the first try, and 3 for guessing on the second turn.");

                string instruction4 = ("If you don't guess the song before the end of the game, when you've run out of turns, you lose!");

                string instruction5 = ("Watch out! You have the option to keep on playing the game until you lose. If you lose then you cannot log your score into the top scores!");

                string instruction6 = ("However you are given the first and last letters of the song name and artist as a hint...");

                string goodLuck = ("GOOD LUCK!");

                string fullInstructions = (instruction1 + "\n" + instruction2 + "\n" + instruction3 + "\n" + instruction4 + "\n" + instruction5 + "\n" + instruction6 + "\n" + goodLuck);

                Console.WriteLine(fullInstructions);
                Console.ReadLine();
            }
            else if (userInstructionsChoice == "no")
            {
                Console.WriteLine("Continuing to menu..."); //Returns to menu when user says no to confirm.
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid input."); //User says neither yes nor no and returns to the menu.
                Console.ReadLine();
            }



        }

        public static void option3() //Option to start the game.
        {

            //Print out random lines from file:

            string[] songList = File.ReadAllLines("songArtistList"); //Reads the whole file.


            Console.WriteLine("Welcome to the game."); //Starts the game.

            Console.ReadLine();
        }

        public static void option4() //Option to exit the program.
        {
            Console.WriteLine("Option 4 was selected. Confirm? Yes/no."); //Asks to confirm.
            string userChoiceOption4 = Console.ReadLine(); //Console reads value.

            if (userChoiceOption4 == "Yes") //User says yes to confirm.
            {
                System.Environment.Exit(0); //Exits program.
            }
            else if (userChoiceOption4 == "No") //User says no to confirm
            {
                Console.WriteLine("Returning to menu...");
                Console.ReadLine(); //Opton ends and returns to menu.
            }
            else
            {
                Console.WriteLine("Invalid input."); //Yes or no wasn't typed and option returns to menu.
                Console.ReadLine();
            }


        }

        public static string randomSongLineGenerator() //Function to select a random line from the song list.
        {
            //Print out random lines from file:

            string[] songList = File.ReadAllLines("songArtistList.txt"); //Console reads the whole file.

            Random r = new Random(); //Random generator.
            int lineNumber = r.Next(0, songList.Length); //Chooses a line between the first line (0) and the length of the song list.

            return (songList[lineNumber]); //Returns the whole line.
        }

      

        public static int splitSongList() //Function to split the song artist from the song name.
        {


            Console.Clear();

            string[] songListSplit = randomSongLineGenerator().Split(','); //Splits the line by a ",".

            string songName = songListSplit[0]; //First value (0 array) is the song name
            string songArtist = songListSplit[1]; //Second value (first array) is the song artist

            char songNameFirstLetter = songName[0]; //First Letter of first word.

            string[] songListSplitWord = songName.Split(' '); //Splits the song name by a space.

            for (int i = 0; i < songListSplitWord.Length; i++)
            {
                string songNameSecondWord = songListSplitWord[i]; //'i' word of line.

                char songNameLetter = songNameSecondWord[0]; //First Letter of 'i' word.

                Console.WriteLine("The first letter of a word in the song is: " + songNameLetter); //Prints the first letter of a word in the song.

            }


            string userGuess; //Setting up variables for the user's guess, the score to add to the total score after the current game and the tracker for the number of guesses.
            int userTempScore = 0;
            int numofguesses = 0;

            Console.WriteLine("The artist of the song is: " + songArtist);

            do
            {

                Console.WriteLine("Please enter your guess"); //Asks to enter guess.
                userGuess = Console.ReadLine(); //Console reads value.

                numofguesses++; //Adds one to the num of guesses for the console to keep track of the guess limit.


            } while (userGuess != songName && numofguesses < 2); //Performs the do... while loop when user hasn't guessed songName and has had less than 2 guesses.

            if (userGuess == songName) //Correct guess.
            {

                Console.WriteLine("You guessed correct");

                if (numofguesses == 1) //First guess.
                {
                    userTempScore = 3; //Adds three.

                }
                else if (numofguesses == 2) //Second guess.
                {
                    userTempScore = 1; //Adds one.
                }
            }

            else //Incorrect guess.
            {
                Console.WriteLine("You didn't guess the song within two tries. Sorry!");
                Console.ReadLine();

                System.Environment.Exit(0); //Exits the program.
            }

            return userTempScore;

        }

        public static void option5()
        {

            string[] userList = File.ReadAllLines("playerNamesList.txt"); //Console reads the whole file.

            string highestUserSoFar = ""; //Empty string until it's given a value.
            int highestScoreSoFar = -1;
            for (int i =0; i < userList.Length; i++)
            {
                //This runs for every line of the file tracking the higest scoring user so far.
                string[] singleLine = userList[i].Split(',');

                if (Int32.Parse(singleLine[1]) > highestScoreSoFar)
                {
                    highestScoreSoFar = Int32.Parse(singleLine[1]); //Must use parse to convert the score to an int format before comparing. 
                    highestUserSoFar = userList[i]; //The highest score so far is the selected line of the list.
                }
                 


            }

            Console.WriteLine("The highest scoreing user in the file is: " + highestUserSoFar); //Prints the highest user so far.

            
            Console.ReadLine();
           

        }



    }

}