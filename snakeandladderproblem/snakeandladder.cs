using System;
using System.Collections.Generic;
using System.Text;

namespace snakeandladderproblem
{
    class snakeandladder
    {
        public void sandl()
        {
            int playerpos= 0;
            int previousposition = 0;
            int count = 0;
            
            while (playerpos < 100)
            {
                count++;
                Random random = new Random();
                int roll = random.Next(1, 7);
                int option = random.Next(1, 3);
                switch (option)
                {
                    case 1:
                        Console.WriteLine("roll value is" + roll);
                        Console.WriteLine("Ladder");
                        playerpos += roll;
                        if (playerpos > 100)
                        {
                            playerpos -= roll;
                            previousposition = playerpos;
                            Console.WriteLine("player position will retain in :"+previousposition);
                        }
                        Console.WriteLine("player position is :" + playerpos);
                        break;
                    case 2:
                        Console.WriteLine("roll value is" + roll);
                        Console.WriteLine("Snake");
                        playerpos -= roll;
                        if (playerpos < 0)
                            playerpos = 0;
                        Console.WriteLine("player position is :" + playerpos);
                        break;
                    default:
                        Console.WriteLine("No play");
                        break;
                }
                Console.WriteLine("number of times dice was rolled :"+count);
                
            }

        }
    }
}
