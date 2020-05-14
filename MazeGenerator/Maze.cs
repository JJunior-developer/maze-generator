using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGenerator
{
    public partial class Maze : Form
    {
        cell[,] maze;
        GraphicsState state = null;
        Size baseFormSize;
        public Maze()
        {
            InitializeComponent();

            mazeConstructor builder = new mazeConstructor();
            maze = builder.constructMaze();

            int width = Settings.MazeWidth * Settings.CellSize;
            int height = Settings.MazeHeight * Settings.CellSize;

            Console.WriteLine(width);

            baseFormSize = new Size(width + 40, height + 60);

            mazePanel.Size = baseFormSize;
            this.Size = new System.Drawing.Size(width + 40, height + 60);

        }


        private void ReDraw()
        {
            Graphics g = mazePanel.CreateGraphics();

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

            g.FillPolygon(brush, points1);

            brush.Color = Settings.EndPointColour;
            g.FillPolygon(brush, points2);

            //Draw grid
            //------------------------------------------------------------------------------------//
            Pen pen = new Pen(Settings.GridColour, 3);

            foreach (cell cell in maze)
            {
                if (cell.WallNorth) { g.DrawLine(pen, cell.pointTL, cell.pointTR); }
                if (cell.WallEast) { g.DrawLine(pen, cell.pointTR, cell.pointBR); }
                if (cell.WallSouth) { g.DrawLine(pen, cell.pointBL, cell.pointBR); }
                if (cell.WallWest) { g.DrawLine(pen, cell.pointTL, cell.pointBL); }
            }

            state = g.Save();
            g.Dispose();
        }

        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (state == null) { ReDraw(); }
            else { e.Graphics.Restore(state); }
        }

        private void MazePanel_Resize(object sender, EventArgs e)
        {
            Size changeInSize = baseFormSize - this.Size;
            if (changeInSize.Width > 0 || changeInSize.Height > 0)
            {
                ReDraw();
            }
        }
    }
}
