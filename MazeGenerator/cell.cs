﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MazeGenerator
{
    class cell
    {
        public readonly Point pointTL;
        public readonly Point pointTR;
        public readonly Point pointBL;
        public readonly Point pointBR;

        public cell(Point a, Point b, Point c, Point d)
        {
            pointTL = a;
            pointTR = b;
            pointBL = c;
            pointBR = d;
        }

        private bool wallNorth = true;
        public bool WallNorth
        {
            get { return wallNorth; }
            set { wallNorth = value; }
        }

        private bool wallEast = true;
        public bool WallEast
        {
            get { return wallEast; }
            set { wallEast = value; }
        }

        private bool wallSouth = true;
        public bool WallSouth
        {
            get { return wallSouth; }
            set { wallSouth = value; }
        }

        private bool wallWest = true;
        public bool WallWest
        {
            get { return wallWest; }
            set { wallWest = value; }
        }

        private int condition = 0;
        public int Condition
        {
            get { return condition; }
            private set { condition = value; }
        }

        private bool visited = false;
        public bool Visited
        {
            get { return visited; }
            set { visited = value; }
        }

        public int numberOfWalls()
        {
            int numWalls = 0;
            if (wallNorth) { numWalls++; }
            if (wallEast) { numWalls++; }
            if (wallSouth) { numWalls++; }
            if (wallWest) { numWalls++; }

            return numWalls;
        }
    }

}
