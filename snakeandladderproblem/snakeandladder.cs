using System;
using System.Collections.Generic;
using System.Text;

namespace snakeandladderproblem
{
    class Snakeandladder
    {
        const int LADDER = 1;
        const int SNAKE = 2;
        const int PLAYER1 = 1;
        int player1pos=0;
        int player2pos = 0;
        int previousposition = 0;
        int player1dicecount = 0;
        int player2dicecount = 0;
        public void sandl()
        {
            while (true)
            {
                Random random = new Random();
                int playeroption = random.Next(1, 3);
                if (playeroption == PLAYER1)
                {
                        player1();
                }
                else
                {
                        player2();
                }
                if (player1pos <= 100 || player2pos <= 100)
                {
                if (player1pos == 100)
                {
                        Console.WriteLine(".................................");
                        Console.WriteLine("Hurrrrraaaaahhhhhh");
                        Console.WriteLine("player1 won the match");
                        break;
                }
                if (player2pos==100)
                {
                        Console.WriteLine("...................................");
                        Console.WriteLine("Huuuurrrrraaaahhhhh");
                        Console.WriteLine("player 2 won the match");
                        break;
                }
                }
            }

        }
        public void player1()
        {
            while (player1pos<100)
            {
                Console.WriteLine("......................................");
                Console.WriteLine("player1 rolled");
                Random random = new Random();
                int roll = random.Next(1, 7);
                int option = random.Next(0, 3);
                switch (option)
                {
                    case LADDER:
                        player1dicecount++;
                        Console.WriteLine("roll value is" + roll);
                        Console.WriteLine("Ladder");
                        player1pos += roll;
                        if (player1pos > 100)
                        {
                            player1pos -= roll;
                            previousposition = player1pos;
                            Console.WriteLine("player position will retain in :" + previousposition);
                        }
                        Console.WriteLine("player position is :" + player1pos);
                        break;
                    case SNAKE:
                        player1dicecount++;
                        Console.WriteLine("roll value is" + roll);
                        Console.WriteLine("Snake");
                        player1pos -= roll;
                        if (player1pos < 0)
                            player1pos = 0;
                        Console.WriteLine("player position is :" + player1pos);
                        break;
                    default:
                        Console.WriteLine("No play");
                        break;
                }
                Console.WriteLine("number of times dice was rolled :" + player1dicecount);
                if (option == 1)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            
        }
        public void player2()
        {
            while (player2pos<100)
            {
                Console.WriteLine("..........................................");
                Console.WriteLine("player 2 rolled");
                Random random = new Random();
                int roll = random.Next(1, 7);
                int option = random.Next(0, 3);
                switch (option)
                {
                    case LADDER:
                        player2dicecount++;
                        Console.WriteLine("roll value is" + roll);
                        Console.WriteLine("Ladder");
                        player2pos += roll;
                        if (player2pos > 100)
                        {
                            player2pos -= roll;
                            previousposition = player2pos;
                            Console.WriteLine("player position will retain in :" + previousposition);
                        }
                        Console.WriteLine("player position is :" + player2pos);
                        
                        break;
                    case SNAKE:
                        player2dicecount++;
                        Console.WriteLine("roll value is" + roll);
                        Console.WriteLine("Snake");
                        player2pos -= roll;
                        if (player2pos < 0)
                            player2pos = 0;
                        Console.WriteLine("player position is :" + player2pos);
                        break;
                    default:
                        Console.WriteLine("No play");
                        break;
                }
 
                Console.WriteLine("number of times dice was rolled :" + player2dicecount);
                if (option == 1)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
