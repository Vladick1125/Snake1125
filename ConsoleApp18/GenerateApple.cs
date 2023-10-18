using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static void GenerateApple()
        {
           
            for (int i = 0; i < 2; i++)
                apple[i] = random.Next(0, 40);
            apple[0] = apple[0] * 10;
            apple[1] = apple[1] * 10;
            graphics.FillEllipse(System.Drawing.Brushes.Green, apple[0], apple[1], 10, 10);
        }


    }
}

