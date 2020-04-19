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
        Settings settings = new Settings();
        public cell[,] constructMaze()
        {

            cell[,] maze = new cell[settings.MazeHeight, settings.MazeWidth];

            for (int height = 0; height < settings.MazeHeight; height++)
            {
                for (int width = 0; width < settings.MazeWidth; width++)
                {
                    //Layout of cell
                    //a  b
                    //c  d
                    Point a = new Point(width * settings.CellSize, height * settings.CellSize);
                    Point b = new Point(a.X + settings.CellSize, height * settings.CellSize);
                    Point c = new Point(a.X, a.Y + settings.CellSize);
                    Point d = new Point(b.X, c.Y);

                    maze[height, width] = new cell(a, b ,c ,d);
                }
            }

            maze = createMazePath(maze);

            Console.WriteLine("Cell 1");
            Console.WriteLine("North:" + maze[0,0].WallNorth);
            Console.WriteLine("East:" + maze[0, 0].WallEast);
            Console.WriteLine("South:" + maze[0, 0].WallSouth);
            Console.WriteLine("West:" + maze[0, 0].WallWest);

            Console.WriteLine("\nCell ->");
            Console.WriteLine("North:" + maze[0, 1].WallNorth);
            Console.WriteLine("East:" + maze[0, 1].WallEast);
            Console.WriteLine("South:" + maze[0, 1].WallSouth);
            Console.WriteLine("West:" + maze[0, 1].WallWest);

            Console.WriteLine(@"Cell \/");
            Console.WriteLine("North:" + maze[1, 0].WallNorth);
            Console.WriteLine("East:" + maze[1, 0].WallEast);
            Console.WriteLine("South:" + maze[1, 0].WallSouth);
            Console.WriteLine("West:" + maze[1, 0].WallWest);

            Console.WriteLine(@"Cell ->\/");
            Console.WriteLine("North:" + maze[1, 1].WallNorth);
            Console.WriteLine("East:" + maze[1, 1].WallEast);
            Console.WriteLine("South:" + maze[1, 1].WallSouth);
            Console.WriteLine("West:" + maze[1, 1].WallWest);



            return maze;
        }

        private cell[,] createMazePath(cell[,] grid)
        {
            Random rand = new Random();
            List<char> possibleNeighbors;

            int currentY = 0;
            int currentX = 0;

            while ((possibleNeighbors = unvisitedNeighbors(currentY, currentX, ref grid)).Count > 0)
            {
                grid[currentY, currentX].Visited = true;

                int nextIteration = rand.Next(0, possibleNeighbors.Count);
                char move = possibleNeighbors[nextIteration];
                
                switch (move)
                {
                    case 'N':
                        Console.WriteLine("North");
                        grid[currentY, currentX].WallNorth = false;
                        currentY--;
                        grid[currentY, currentX].WallSouth = false;
                        break;

                    case 'E':
                        Console.WriteLine("East");
                        grid[currentY, currentX].WallEast = false;
                        currentX++;
                        grid[currentY, currentX].WallWest = false;
                        break;

                    case 'S':
                        Console.WriteLine("South");
                        grid[currentY, currentX].WallSouth = false;
                        currentY++;
                        grid[currentY, currentX].WallNorth = false;
                        break;

                    case 'W':
                        Console.WriteLine("West");
                        grid[currentY, currentX].WallWest = false;
                        currentX--;
                        grid[currentY, currentX].WallEast = false;
                        break;
                }
            }

            return grid;
        }

        private List<char> unvisitedNeighbors(int currentY, int currentX, ref cell[,] grid)
        {
            List<char> availableNeighbors = new List<char>();

            if (currentY > 0)
            {
                if (!grid[currentY - 1, currentX].Visited) { availableNeighbors.Add('N'); }
            }

            if (currentX < settings.MazeWidth - 1)
            {
                if (!grid[currentY, currentX + 1].Visited) { availableNeighbors.Add('E'); }
            }

            if (currentY < settings.MazeHeight - 1)
            {
                if (!grid[currentY + 1, currentX].Visited) { availableNeighbors.Add('S'); }
            }

            if (currentX > 0)
            {
                if (!grid[currentY, currentX - 1].Visited) { availableNeighbors.Add('W'); }
            }

            return availableNeighbors;
        }
    }
}
