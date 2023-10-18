using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static void CleanTail()
        {
            var index = snake.Count - 1;
            
            graphics.FillRectangle(System.Drawing.Brushes.Black, snake[index][0], snake[index][1], 10, 10);
            // отрисовать черный круг размером 10 на 10 по координатам последней ячейки
        }
    }
}
