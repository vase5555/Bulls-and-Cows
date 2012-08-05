using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bows_And_Cows
{
    public class Play
    {
        public void PlayBullsAndCows()
        {
            BowsAndCows game = new BowsAndCows();
            ScoreBoard scoreboard = new ScoreBoard();
            Console.WriteLine("Welcome to “Bulls and Cows” game. Please try to guess my secret 4-digit number.");
            Console.WriteLine("Use 'top' to view the top scoreboard, 'restart' to start a new game and 'help' to cheat and 'exit' to quit the game.");
            while (true)
            {
                Console.Write("Enter your guess or command: ");
                string number = Console.ReadLine();
                int tryNumber = 0;
                if (int.TryParse(number, out tryNumber) && number.Length == 4)
                {
                    int[] currentNumber = new int[4];
                    for (int i = 0; i < 4; i++)
                    {
                        currentNumber[i] = int.Parse(number[i].ToString());
                    }
                    if (game.FindBowsAndCows(currentNumber))
                    {
                        if (game.HasUseHelp == false)
                        {
                            if (scoreboard.CheckForAdding(game.Attemts))
                            {
                                Console.Write("Please enter your name for the top scoreboard:  ");
                                string nickname = Console.ReadLine();
                                scoreboard.AddNewScore(nickname, game.Attemts);
                            }
                        }
                        BowsAndCows newGame = new BowsAndCows();
                        game = newGame;
                        Console.WriteLine("Welcome to “Bulls and Cows” game. Please try to guess my secret 4-digit number.");
                        Console.WriteLine("Use 'top' to view the top scoreboard, 'restart' to start a new game and 'help' to cheat and 'exit' to quit the game.");
                    }
                }
                else if(number.ToLower() == "restart")
                {
                    BowsAndCows newGame = new BowsAndCows();
                    game = newGame;
                    Console.Clear();
                    Console.WriteLine("Welcome to “Bulls and Cows” game. Please try to guess my secret 4-digit number.");
                    Console.WriteLine("Use 'top' to view the top scoreboard, 'restart' to start a new game and 'help' to cheat and 'exit' to quit the game.");
                }
                else if (number.ToLower() == "help")
                {
                    game.Help();
                }
                else if (number.ToLower() == "top")
                {
                    scoreboard.ShowScoreBoard();
                }
                else if (number.ToLower() == "exit")
                {
                    Console.WriteLine("Good bye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect guess or command!");
                }
                Console.WriteLine();
            }
        }
       
    }
}
