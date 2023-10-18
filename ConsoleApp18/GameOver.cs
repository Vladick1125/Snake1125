using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {

        private static void GameOver()
        {
            gameRunning = false;
            graphics.Clear(Color.Black);
            Console.WriteLine($"Итоговое количество очков: {gameScore}");
            Console.WriteLine("Нажмите клавишу 'm', чтобы начать заново.");
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.M)
                {
                    break;
                }
            }
        }

        

    }
}
