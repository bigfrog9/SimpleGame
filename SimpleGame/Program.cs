using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    internal class Program
    {
        static bool gameOver;
        static int x;
        static int y;
        static ConsoleKeyInfo input;

        static void Main(string[] args)
        {
            gameOver = false;

            y = 50;
            x = 50;

            //game loop
            while (gameOver == false)
            {

                //update
                PlayerUpdate();

                //draw
                PlayerDraw();

            }

                
        }

        static void PlayerUpdate()
        {
            //read user input
            input = Console.ReadKey(true);

            //update player position
            
            if (input.KeyChar == 'w')
            {
                y = y - 1;
            }

            if (input.KeyChar == 's')
            {
                y = y + 1;
            }

            if (input.KeyChar == 'a')
            {
                x = x - 1;
            }

            if (input.KeyChar == 'd')
            {
                x = x + 1;
            }

            if (input.Key == ConsoleKey.Escape)
            {
                gameOver = true;
            }
        }
        
        static void PlayerDraw()
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write("@");

        }
    }
}
