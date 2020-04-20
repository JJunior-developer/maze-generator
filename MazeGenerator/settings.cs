using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MazeGenerator
{
    static class Settings
    {
        private static int cellSize = 30;
        public static int CellSize
        {
            get { return cellSize; }
            set { cellSize = value; }
        }

        private static int mazeWidth = 10;
        public static int MazeWidth
        {
            get { return mazeWidth; }
            set { mazeWidth = value; }
        }

        private static int mazeHeight = 10;
        public static int MazeHeight
        {
            get { return mazeHeight; }
            set { mazeHeight = value; }
        }

        private static Point startPoint;
        public static Point StartPoint
        {
            get { return startPoint; }
            set { startPoint = value; }
        }

        private static Point endPoint;
        public static Point EndPoint
        {
            get { return endPoint; }
            set { endPoint = value; }
        }

        private static Color startPointColour = Color.Red;
        public static Color StartPointColour
        {
            get { return startPointColour; }
            set { startPointColour = value; }
        }

        private static Color endPointColour = Color.Green;
        public static Color EndPointColour
        {
            get { return endPointColour; }
            set { endPointColour = value; }
        }

        private static Color gridColour = Color.Black;
        public static Color GridColour
        {
            get { return gridColour; }
            set { gridColour = value; }
        }
    }
}
