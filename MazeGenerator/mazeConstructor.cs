using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Collections;

namespace MazeGenerator
{
    class mazeConstructor
    {
        public cell[,] constructMaze()
        {

            cell[,] maze = new cell[Settings.MazeHeight, Settings.MazeWidth];

            for (int height = 0; height < Settings.MazeHeight; height++)
            {
                for (int width = 0; width < Settings.MazeWidth; width++)
                {
                    //Layout of cell
                    //a  b
                    //c  d
                    Point a = new Point(width * Settings.CellSize, height * Settings.CellSize);
                    Point b = new Point(a.X + Settings.CellSize, height * Settings.CellSize);
                    Point c = new Point(a.X, a.Y + Settings.CellSize);
                    Point d = new Point(b.X, c.Y);

                    maze[height, width] = new cell(a, b ,c ,d);
                }
            }

            maze = createMazePath(maze);

            return maze;
        }


        private cell[,] createMazePath(cell[,] grid)
        {
            Random rand = new Random();
            List<char> possibleNeighbors;
            Stack availableNodes = new Stack();

            Point currentPosition = Settings.StartPoint;
            grid[currentPosition.Y, currentPosition.X].Visited = true;

            do
            {
                while ((possibleNeighbors = unvisitedNeighbors(currentPosition, ref grid)).Count > 0)
                {
                    if (possibleNeighbors.Count > 1)
                    {
                        Point copy = new Point(currentPosition.X, currentPosition.Y);
                        availableNodes.Push(copy);
                    }

                    //grid[currentPosition.Y, currentPosition.X].Visited = true;

                    int nextIteration = rand.Next(0, possibleNeighbors.Count);
                    char move = possibleNeighbors[nextIteration];

                    switch (move)
                    {
                        case 'N':
                            //Console.WriteLine("North");
                            grid[currentPosition.Y, currentPosition.X].WallNorth = false;
                            currentPosition.Y--;
                            grid[currentPosition.Y, currentPosition.X].WallSouth = false;
                            break;

                        case 'E':
                            //Console.WriteLine("East");
                            grid[currentPosition.Y, currentPosition.X].WallEast = false;
                            currentPosition.X++;
                            grid[currentPosition.Y, currentPosition.X].WallWest = false;
                            break;

                        case 'S':
                            //Console.WriteLine("South");
                            grid[currentPosition.Y, currentPosition.X].WallSouth = false;
                            currentPosition.Y++;
                            grid[currentPosition.Y, currentPosition.X].WallNorth = false;
                            break;

                        case 'W':
                            //Console.WriteLine("West");
                            grid[currentPosition.Y, currentPosition.X].WallWest = false;
                            currentPosition.X--;
                            grid[currentPosition.Y, currentPosition.X].WallEast = false;
                            break;
                    }
                    grid[currentPosition.Y, currentPosition.X].Visited = true;
                }
                currentPosition = (Point)availableNodes.Pop();
            }
            while (availableNodes.Count > 0);

            return grid;
        }

        private List<char> unvisitedNeighbors(Point current, ref cell[,] grid)
        {
            List<char> availableNeighbors = new List<char>();

            if (current.Y > 0)
            {
                if (!grid[current.Y - 1, current.X].Visited) { availableNeighbors.Add('N'); }
            }

            if (current.X < Settings.MazeWidth - 1)
            {
                if (!grid[current.Y, current.X + 1].Visited) { availableNeighbors.Add('E'); }
            }

            if (current.Y < Settings.MazeHeight - 1)
            {
                if (!grid[current.Y + 1, current.X].Visited) { availableNeighbors.Add('S'); }
            }

            if (current.X > 0)
            {
                if (!grid[current.Y, current.X - 1].Visited) { availableNeighbors.Add('W'); }
            }

            return availableNeighbors;
        }
    }
}
