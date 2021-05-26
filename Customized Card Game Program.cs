using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameAlgorithms
{
    class Program
    {
        //Set player scores to 0 for the start:
            int player1score = 0;
            int player2score = 0;

            //Start of round 1:
            Card card = selectRandomCard(); //This selects a random card.
            Console.WriteLine("Card chosen is " + card.colour + " and value " + card.value);
            if (card.value > 7)
            {
                player1score++;
                Console.WriteLine("Player 1 wins!");
            }
            else
            {
                player2score++;
                Console.WriteLine("Player 2 wins!");
            }

            Console.WriteLine("   ");
            Console.WriteLine("Round 2 is a special round: your score goes to 0 if your card is more or equal to 10!");
            Console.WriteLine("   ");

            Card card0 = selectRandomCard(); //This selects a random card.
            Console.WriteLine("Card chosen is " + card0.colour + " and value " + card0.value);
            if (card0.value >= 10)
            {
                player1score = 0;
                Console.WriteLine("Player 1 wins!");
            }
            else
            {
                player2score = 0;
                Console.WriteLine("Player 2 wins!");
            }

            Card card1 = selectRandomCard(); //This selects a random card.
            Console.WriteLine("Card chosen is " + card1.colour + " and value " + card1.value);
            if (card1.value <= 7)
            {
                player1score++;
                Console.WriteLine("Player 1 wins!");
            }
            else
            {
                player2score++;
                Console.WriteLine("Player 2 wins!");
            }

            Console.WriteLine("   ");
            Console.WriteLine("Round 4 is a special round: double your current score if you win!");
            Console.WriteLine("   ");

            Card card2 = selectRandomCard(); //This selects a random card.
            Console.WriteLine("Card chosen is " + card2.colour + " and value " + card2.value);
            if (card2.value <=10)
            {
                player1score*2;
                Console.WriteLine("Player 1 won the special round!");
            }
            else
            {
                player2score*2;
                Console.WriteLine("Player 2 won the special round!");
            }

            Card card3 = selectRandomCard(); //This selects a random card.
            Console.WriteLine("Card chosen is " + card3.colour + " and value " + card3.value);
            if (card3.value >= 7)
            {
                player1score++;
                Console.WriteLine("Player 1 wins!");
            }
            else
            {
                player2score++;
                Console.WriteLine("Player 2 wins!");
            }

            Card card4 = selectRandomCard(); //This selects a random card.
            Console.WriteLine("Card chosen is " + card4.colour + " and value " + card4.value);
            if (card4.value == 7)
            {
                player1score++;
                Console.WriteLine("Player 1 wins!");
            }
            else
            {
                player2score++;
                Console.WriteLine("Player 2 wins!");
            }

            Card card5 = selectRandomCard(); //This selects a random card.
            Console.WriteLine("Card chosen is " + card5.colour + " and value " + card5.value);
            if (card5.value == 7)
            {
                player2score++;
                Console.WriteLine("Player 2 wins!");
            }
            else
            {
                player1score++;
                Console.WriteLine("Player 1 wins!");
            }

            //End of the rounds, printing scores:
            Console.WriteLine("Player 1 score is " + player1score + " Player 2 score is " + player2score);


            //Counting up the final score:
            if (player1score > player2score)
            {
                Console.WriteLine("Player 1 won overall.");
            } 
            else if (player1score == player2score)
            {
                Console.WriteLine("It's a draw.");
            }
            else 
            {
                Console.WriteLine("Player 2 won overall.");
            }


            Console.ReadLine(); //pauses program
        }


        //dont alter code below
        static Random r = new Random();

        public struct Card
        {
            public string colour;
            public int value;
        }
        static public Card selectRandomCard()
        {
            Card c = new Card();
            c.value = r.Next(1, 14); // number from 1-13 chosen
            c.colour = r.Next(0, 2) == 1 ? "red" : "black" ; //alternative way to write if statment                     
            return c;
        }

        //dont alter code below
        static Random r = new Random();

        public struct Card
        {
            public string colour;
            public int value;
        }
        static public Card selectRandomCard()
        {
            Card c = new Card();
            c.value = r.Next(1, 14); // number from 1-13 chosen
            c.colour = r.Next(0, 2) == 1 ? "red" : "black" ; //alternative way to write if statment                     
            return c;
        }

    }
}
