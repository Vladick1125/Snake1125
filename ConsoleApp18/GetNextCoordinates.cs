using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static int[] GetNextCoordinates()
        {
            int[] coordinates = new int[2] { snake[0][0], snake[0][1] };

            if (direction == 1)
            {
                coordinates[1] = coordinates[1] - 10;
                if (coordinates[1] < 0) 
                    coordinates[1] = 470; 
            }
            if (direction == 2)
            {
                coordinates[0] = coordinates[0] + 10;
                if (coordinates[0] > 950) 
                    coordinates[0] = 0; 
            }
            if (direction == 3)
            {
                coordinates[1] = coordinates[1] + 10;
                if (coordinates[1] > 470) 
                    coordinates[1] = 0; 
            }
            if (direction == 4)
            {
                coordinates[0] = coordinates[0] - 10;
                if (coordinates[0] < 0) 
                    coordinates[0] = 950; 
            }

            controlBlock = false;
            return coordinates;
        }

    }
}
