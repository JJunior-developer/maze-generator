using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGenerator
{
    class Settings
    {
        private int cellSize = 30;
        public int CellSize
        {
            get { return cellSize; }
            private set { cellSize = value; }
        }

        private int mazeWidth = 10;
        public int MazeWidth
        {
            get { return mazeWidth; }
            private set { mazeWidth = value; }
        }

        private int mazeHeight = 10;
        public int MazeHeight
        {
            get { return mazeHeight; }
            private set { mazeHeight = value; }
        }
    }
}
