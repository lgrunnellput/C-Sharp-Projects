using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Rock_Paper_Scissors_Game
{
    class Program
    {

        public static void VSComputer()
        {
            //Set player scores to 0 for the start:
            int player1score = 0;
            int computerScore = 0;

            string userInput = "no";
            while (userInput == "no")
            {
                Console.WriteLine("Do you choose rock, paper or scissors");
                string userChoice = Console.ReadLine();

                Random r = new Random();
                int computerChoice = r.Next(1, 4);

                if (computerChoice == 1)
                {
                    if (userChoice == "rock" || userChoice == "r")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("It is a draw");

                    }
                    else if (userChoice == "paper" || userChoice == "p")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("You win");
                        player1score++;
                        Console.WriteLine("Your score is now: " + player1score);

                    }
                    else if (userChoice == "scissors" || userChoice == "s")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("You lose");
                        computerScore++;
                        Console.WriteLine("The computer's score is now: " + computerScore);
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock, paper or scissors!");

                    }

                }

                else if (computerChoice == 2)
                {
                    if (userChoice == "rock" || userChoice == "r")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("You lose");
                        computerScore++;
                        Console.WriteLine("The computer's score is now: " + computerScore);

                    }
                    else if (userChoice == "paper" || userChoice == "p")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("It's a draw");

                    }
                    else if (userChoice == "scissors" || userChoice == "s")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("You win");
                        player1score++;
                        Console.WriteLine("Your score is now: " + player1score);
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock, paper or scissors!");
                    }
                }
                else if (computerChoice == 3)
                {
                    if (userChoice == "rock" || userChoice == "r")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("You win");
                        player1score++;
                        Console.WriteLine("Your score is now: " + player1score);

                    }
                    else if (userChoice == "paper" || userChoice == "p")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("You lose");
                        computerScore++;
                        Console.WriteLine("The computer's score is now: " + computerScore);

                    }
                    else if (userChoice == "scissors" || userChoice == "s")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("It's a draw");

                    }
                    else
                    {
                        Console.WriteLine("You must choose rock, paper or scissors!");

                    }

                }

                Console.WriteLine("Would you like to change mode? Type yes or no.");
                userInput = Console.ReadLine();

            }

            if (computerScore > player1score)
            {
                Console.WriteLine("You lost, the computer beat you!");
                Console.WriteLine("Your score was: " + player1score + ".");
                Console.WriteLine("The computer's score was: " + computerScore + ".");

            }
            if (player1score > computerScore)
            {
                Console.WriteLine("You won, you beat the computer!");
                Console.WriteLine("Your score was: " + player1score + ".");
                Console.WriteLine("The computer's score was: " + computerScore + ".");

            }
            if (player1score == computerScore)
            {
                Console.WriteLine("It's a draw!");
                Console.WriteLine("Your score was: " + player1score + ".");
                Console.WriteLine("The computer's score was: " + computerScore + ".");

            }

            Console.ReadLine();
        }


        public static void VSPlayer()
        {
            //Set player scores to 0 for the start:
            int player1score = 0;
            int player2score = 0;

            string userInput = "yes";
            while (userInput == "yes")
            {
                Console.WriteLine("Player 1, do you choose rock, paper or scissors");
                string userChoice = Console.ReadLine();

                Console.Clear();

                Console.WriteLine("Player 2, do you choose rock, paper or scissors");
                string userChoice2 = Console.ReadLine();

                //1 is rock.
                //2 is paper.
                //3 is scissors.

                if (userChoice2 == "rock" || userChoice2 == "r")
                {
                    if (userChoice == "rock" || userChoice == "r")
                    {
                        Console.WriteLine("Player 2 chose rock");
                        Console.WriteLine("It is a draw");

                    }
                    else if (userChoice == "paper" || userChoice == "p")
                    {
                        Console.WriteLine("Player 2 chose rock");
                        Console.WriteLine("Player 1 wins");
                        player1score++;
                        Console.WriteLine("Your score is now: " + player1score);

                    }
                    else if (userChoice == "scissors" || userChoice == "s")
                    {
                        Console.WriteLine("Player 2 chose rock");
                        Console.WriteLine("Player 1 loses");
                        player2score++;
                        Console.WriteLine("Player 2's score is now: " + player2score);
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock, paper or scissors!");

                    }

                }

                else if (userChoice2 == "paper" || userChoice2 == "p")
                {
                    if (userChoice == "rock" || userChoice == "r")
                    {
                        Console.WriteLine("Player 2 chose paper");
                        Console.WriteLine("Player 1 loses");
                        player2score++;
                        Console.WriteLine("Player 2's score is now: " + player2score);

                    }
                    else if (userChoice == "paper" || userChoice == "p")
                    {
                        Console.WriteLine("Player 2 chose paper");
                        Console.WriteLine("It's a draw");

                    }
                    else if (userChoice == "scissors" || userChoice == "s")
                    {
                        Console.WriteLine("Player 2 chose paper");
                        Console.WriteLine("Player 1 wins");
                        player1score++;
                        Console.WriteLine("Player 1's score is now: " + player1score);
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock, paper or scissors!");
                    }
                }
                else if (userChoice2 == "scissors" || userChoice2 == "s")
                {
                    if (userChoice == "rock" || userChoice == "r")
                    {
                        Console.WriteLine("Player 2 chose scissors");
                        Console.WriteLine("Player 1 wins");
                        player1score++;
                        Console.WriteLine("Player 1's score is now: " + player1score);

                    }
                    else if (userChoice == "paper" || userChoice == "p")
                    {
                        Console.WriteLine("Player 2 chose scissors");
                        Console.WriteLine("Player 1 loses");
                        player2score++;
                        Console.WriteLine("Player 2's score is now: " + player2score);

                    }
                    else if (userChoice == "scissors" || userChoice == "s")
                    {
                        Console.WriteLine("Player 2 chose scissors");
                        Console.WriteLine("It's a draw");

                    }
                    else
                    {
                        Console.WriteLine("You must choose rock, paper or scissors!");

                    }

                }




                Console.WriteLine("Would you like to play rock, paper, scissors again? Type yes or no.");
                userInput = Console.ReadLine();

            }

            if (player2score > player1score)
            {
                Console.WriteLine("Player 1 lost, player 2 beat you!");
                Console.WriteLine("Player 1's score was: " + player1score + ".");
                Console.WriteLine("Player 2's score was: " + player2score + ".");

            }
            if (player1score > player2score)
            {
                Console.WriteLine("Player 1 won, you beat player 2!");
                Console.WriteLine("Player 1's score was: " + player1score + ".");
                Console.WriteLine("Player 2's score was: " + player2score + ".");

            }
            if (player1score == player2score)
            {
                Console.WriteLine("It's a draw!");
                Console.WriteLine("Your score was: " + player1score + ".");
                Console.WriteLine("The other player's score was: " + player2score + ".");

            }

            Console.ReadLine();
        }


        static void Main(string[] args)
        { 
      

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Option 1: Play against the computer.");
                Console.WriteLine("Option 2: Play against another player. (Two player mode).");
                Console.WriteLine("Option 3: CLOSE THE PROGRAM!");
                Console.WriteLine("Please type the number of the option you would like to play:");
                int optionNo = Int32.Parse(Console.ReadLine());

                switch (optionNo)
                {
                    case 1: VSComputer(); break;
                    case 2: VSPlayer(); break;
                    case 3: System.Environment.Exit(0); break;
                    default: Console.WriteLine("Please enter a valid option!"); break;
                }
            }

         


        }
    }
}
