using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased
{
    public class SnakeAndLadder
    {
        public static int CheckplayerBiteBySnakeORplayerClimbLadder(int player, int[] start ,int[] end)
        {
            for (int i = 0; i < start.Length; i++)
            {
                if (player == start[i])
                {
                    player = end[i];
                    break;
                }

            }
            return player;
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("GAME START");

            Console.WriteLine("ENTER NUMBER OF PLAYERS (min-2 , max-4)");

            int NumberOfplayers = Convert.ToInt32(Console.ReadLine());

            if (NumberOfplayers < 2 || NumberOfplayers > 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Sorry..No of players are invalid (input range is 2-4)");
                Console.ResetColor();
                return;

            }

            string[] players = new string[NumberOfplayers];

            int[] position = new int[NumberOfplayers];


            Console.WriteLine("Enter names of the player");
            for (int i = 0; i < NumberOfplayers; i++)
            {
                players[i] = Console.ReadLine();
                position[i] = 0;

            }


            int[] starting = { 5, 12, 17, 20, 28, 40, 52, 54, 62, 64, 71, 85, 90, 95, 99 };

            int[] ending = { 14, 30, 6, 35, 82, 55, 66, 32, 18, 58, 91, 21, 71, 77, 78 };

            bool gameFinish = false;

            while (!gameFinish)
            {
                for (int i = 0; i < NumberOfplayers; i++)
                {
                    bool extraChance = true;
                    while (extraChance)
                    {
                        extraChance = false;

                        Console.WriteLine();

                        Console.WriteLine(players[i] + " turn  to roll the dice");

                        Console.WriteLine("press enter to roll a dice");

                        Console.ReadLine();

                        int dice = new Random().Next(1, 7);

                        int oldpos = position[i];

                        int newpos = oldpos + dice;

                        Console.WriteLine("Dice rolled " + dice);


                        if (newpos > 100)
                        {
                            Console.WriteLine("you have no chance because you roll more than 100 times");

                        }
                        else
                        {
                            position[i] = newpos;

                            int beforePosition = position[i];

                            position[i] = CheckplayerBiteBySnakeORplayerClimbLadder(position[i], starting, ending);

                            if (beforePosition < position[i])
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("woohoo you climb the ladder nice!!");
                                Console.ResetColor();

                            }
                            else if (beforePosition > position[i])
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Oops snake bite's you..Sorry ");
                                Console.ResetColor();

                            }

                            Console.WriteLine("old position" + oldpos + "->" + position[i]);
                            if (position[i] == 100)
                            {
                                Console.WriteLine("cong... " + players[i] + " Wins");
                                gameFinish = true;
                                break;
                            }

                        }

                        if (dice == 6 && !gameFinish)
                        {

                            Console.WriteLine("woohoo you get an extra chance as your dice having number 6");
                            extraChance = true;


                        }
                    }


                    if (gameFinish)
                    {
                        break;
                    }

                }


            }
        }


    }
}
