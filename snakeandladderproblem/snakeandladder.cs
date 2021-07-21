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
            Console.WriteLine("player position is"+playerpos);
            Random random = new Random();
            int roll = random.Next(1, 7);
            playerpos += roll;
            Console.WriteLine("player's new position is:"+playerpos);
        }
    }
}
