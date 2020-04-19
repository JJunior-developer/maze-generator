using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace MazeGenerator
{
    class mazeConstructor
    {
        public cell[,] constructMaze()
        {
            Settings settings = new Settings();

            cell[,] maze = new cell[settings.MazeHeight, settings.MazeWidth];

            for (int h = 0; h < settings.MazeHeight; h++)
            {
                for (int w = 0; w < settings.MazeWidth; w++)
                {
                    //Layout of cell
                    //a  b
                    //c  d
                    Point a = new Point(w * settings.CellSize, h * settings.CellSize);
                    Point b = new Point(a.X + settings.CellSize, h * settings.CellSize);
                    Point c = new Point(a.X, a.Y + settings.CellSize);
                    Point d = new Point(b.X, c.Y);

                    maze[h, w] = new cell(a, b ,c ,d);
                }
            }

            return maze;
        }
    }
}
