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
        private static void DrawHead()
        {
            int r = random.Next(0, 256);
            int g = random.Next(0, 256);
            int b = random.Next(0, 256);
            Color color = Color.FromArgb(r, g, b);
            SolidBrush brush = new SolidBrush(color);
            graphics.FillRectangle(brush, snake[0][0], snake[0][1], 10, 10);
        }
    }
}
