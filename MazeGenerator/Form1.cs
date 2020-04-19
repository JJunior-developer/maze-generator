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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            mazeConstructor builder = new mazeConstructor();

            cell[,] maze = builder.constructMaze();

            Pen pen = new Pen(Color.Black, 3);

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
