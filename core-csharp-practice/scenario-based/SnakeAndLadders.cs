using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.Scenario_based
{
    public class SnakeAndLadders
    {
        public static int CheckSnakeAndLadder(int p, int[] starting, int[] ending)
        {
            for (int i = 0; i < starting.Length; i++)
            {
                if (p == starting[i])
                {
                    p = ending[i];
                    break;
                }

            }
            return p;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of players(2-4)");
            int pc = Convert.ToInt32(Console.ReadLine());
            if (pc < 2 || pc > 4)
            {
                Console.WriteLine("No of players are invalid input in range of 2-4");
                return;
            }
            string[] player = new string[pc];
            int[] pos = new int[pc];
            for (int i = 0; i < pc; i++)
            {
                Console.WriteLine("Enter the name of the player");
                player[i] = Console.ReadLine();
                pos[i] = 0;
            }
            int[] starting = { 4, 9, 17, 20, 28, 40, 51, 54, 62, 64, 71, 87, 93, 95, 99 };
            int[] ending = { 14, 31, 7, 38, 84, 59, 67, 34, 19, 60, 91, 24, 73, 75, 78 };
            bool gameover = false;
            Random random = new Random();
            while (!gameover)
            {
                for (int i = 0; i < pc; i++)
                {
                    bool extra = true;
                    while (extra)
                    {
                        extra = false;
                        Console.WriteLine();
                        Console.WriteLine(player[i] + "roll the dice(Press Enter)");
                        Console.ReadLine();
                        int dice = random.Next(1, 7);
                        int oldpos = pos[i];
                        int newpos = oldpos + dice;
                        Console.WriteLine("Dice rolled" + dice);
                        if (newpos > 100)
                        {
                            Console.WriteLine("your chance is skipped because you got more than 100");

                        }
                        else
                        {
                            pos[i] = newpos;
                            int before = pos[i];
                            pos[i] = CheckSnakeAndLadder(pos[i], starting, ending);
                            if (before < pos[i])
                            {
                                Console.WriteLine("You climbed the ladder");
                            }
                            else if (before > pos[i])
                            {

                                Console.WriteLine("Snake bite");
                            }
                        }
                            Console.WriteLine("old position" + oldpos + "->" + pos[i]);
                            if (pos[i] == 100)
                            {
                                Console.WriteLine("Congratulations" + player[i] + " for winning the game");
                                gameover = true;
                                break;
                            }


                            if (dice == 6 && !gameover)
                            {
                            Console.WriteLine("Extra Chance to roll a dice because you got 6");
                            extra = true;



                            }
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

