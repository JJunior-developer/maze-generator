using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGenerator
{
    public partial class Maze : Form
    {
        public Maze()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            mazeConstructor builder = new mazeConstructor();

            cell[,] maze = builder.constructMaze();

            //Draw start & End point colours
            //------------------------------------------------------------------------------------//

            Point[] points1 =
            {
                maze[Settings.StartPoint.X, Settings.StartPoint.Y].pointTL,
                maze[Settings.StartPoint.X, Settings.StartPoint.Y].pointTR,
                maze[Settings.StartPoint.X, Settings.StartPoint.Y].pointBR,
                maze[Settings.StartPoint.X, Settings.StartPoint.Y].pointBL
            };

            Point[] points2 =
            {
                maze[Settings.EndPoint.X, Settings.EndPoint.Y].pointTL,
                maze[Settings.EndPoint.X, Settings.EndPoint.Y].pointTR,
                maze[Settings.EndPoint.X, Settings.EndPoint.Y].pointBR,
                maze[Settings.EndPoint.X, Settings.EndPoint.Y].pointBL
            };

            SolidBrush brush = new SolidBrush(Settings.StartPointColour);

            e.Graphics.FillPolygon(brush, points1);

            brush.Color = Settings.EndPointColour;
            e.Graphics.FillPolygon(brush, points2);

            //Draw grid
            //------------------------------------------------------------------------------------//
            Pen pen = new Pen(Settings.GridColour, 3);

            foreach (cell cell in maze)
            {
                if (cell.WallNorth) { e.Graphics.DrawLine(pen, cell.pointTL, cell.pointTR); }
                if (cell.WallEast) { e.Graphics.DrawLine(pen, cell.pointTR, cell.pointBR); }
                if (cell.WallSouth) { e.Graphics.DrawLine(pen, cell.pointBL, cell.pointBR); }
                if (cell.WallWest) { e.Graphics.DrawLine(pen, cell.pointTL, cell.pointBL); }
            }

        }
    }
}
