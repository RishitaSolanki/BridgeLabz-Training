using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased
{
    public class Snake_Ladder
    {
        public static int Apply(int p, int[] s, int[] e)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (p == s[i])
                {
                    p = e[i];
                    break;
                }

            }
            return p;
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter number of players(min-2 and max-4)");

            int players = Convert.ToInt32(Console.ReadLine());

            if (players < 2 || players > 4)
            {
                Console.WriteLine(" Sorry..No of players are invalid (input range is 2-4)");
                return;

            }

            string[] player = new string[players];

            int[] position = new int[players];


            Console.WriteLine("Enter names of the player");
            for (int i = 0; i < players; i++)
            {
                player[i] = Console.ReadLine();
                position[i] = 0;

            }


            int[] s = { 4, 9, 17, 20, 28, 40, 51, 54, 62, 64, 71, 87, 93, 95, 99 };
            int[] e = { 14, 31, 7, 38, 84, 59, 67, 34, 19, 60, 91, 24, 73, 75, 78 };

            bool gameover = false;

            while (!gameover)
            {
                for (int i = 0; i < players; i++)
                {
                    bool extra = true;
                    while (extra)
                    {
                        extra = false;

                        Console.WriteLine();

                        Console.WriteLine(player[i] + "turn  to roll the dice");

                        Console.WriteLine("press enter to roll a dice");

                        Console.ReadLine();

                        int dice = new Random().Next(1, 7);

                        int oldpos = position[i];

                        int newpos = oldpos + dice;

                        Console.WriteLine("Dice rolled" + dice);


                        if (newpos > 100)
                        {
                            Console.WriteLine("you have no chance because you roll more than 100 times");

                        }
                        else
                        {
                            position[i] = newpos;

                            int before = position[i];

                            position[i] = Apply(position[i], s, e);

                            if (before < position[i])
                            {
                                Console.WriteLine("woohoo you climb the ladder nice!!");
                            }
                            else if (before > position[i])
                            {
                                Console.WriteLine("Oops snake bite's you..Sorry ");
                            }
                            Console.WriteLine("old position" + oldpos + "->" + position[i]);
                            if (position[i] == 100)
                            {
                                Console.WriteLine("cong... " + player[i] + " Wins");
                                gameover = true;
                                break;
                            }

                        }

                        if (dice == 6 && !gameover)
                        {
                            Console.WriteLine("woohoo you get an extra chance as your dice having number 6");
                            extra = true;



                        }
                    }


                    if (gameover)
                    {
                        break;
                    }

                }


            }
        }


    }
}
