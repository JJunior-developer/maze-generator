using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MazeGenerator
{
    public partial class setup : Form
    {
        public setup()
        {
            InitializeComponent();
            object[] colours = new object[]
            {
                "Black",
                "Red",
                "Green",
                "Yellow",
                "Blue",
                "Purple",
                "Pink",
                "Orange"
            };

            boxGridColour.Items.AddRange(colours);
            boxStartColour.Items.AddRange(colours);
            boxEndColour.Items.AddRange(colours);
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            //Grid details setup
            //---------------------------------------------//
            //Get weight
            if (Int32.TryParse(boxWidth.Text, out int newWidth))
            {
                Settings.MazeWidth = newWidth;
            }
            else { Console.WriteLine("Using default width value."); }

            //Get height
            if (Int32.TryParse(boxHeight.Text, out int newHeight))
            {
                Settings.MazeHeight = newHeight;
            }
            else { Console.WriteLine("Using default height value."); }

            //Get cell size
            if (Int32.TryParse(boxCell.Text, out int newCell))
            {
                Settings.CellSize = newCell;
            }
            else { Console.WriteLine("Using default cell value."); }

            //Get grid colour
            if (boxGridColour.Text != "")
            {
                Settings.GridColour = Color.FromName(boxGridColour.Text);
            }

            //Start point setup
            //---------------------------------------------//
            //Height of start point
            int tempStartH = -1;

            if (Int32.TryParse(boxStartH.Text, out int newStartH))
            {
                if (newStartH > 0 && newStartH < Settings.MazeHeight)
                {
                    tempStartH = newStartH;
                }
            }

            //Width of start point
            if (Int32.TryParse(boxStartW.Text, out int newStartW))
            {
                if (newStartW > 0 && newStartW < Settings.MazeWidth && tempStartH != -1)
                {
                    Settings.StartPoint = new Point(tempStartH, newStartW);
                }
            }

            if (boxStartColour.Text != "")
            {
                Settings.StartPointColour = Color.FromName(boxStartColour.Text);
            }
            //End point setup
            //---------------------------------------------//
            //Height of end point
            int tempEndH = -1;

            if (Int32.TryParse(boxEndH.Text, out int newEndH))
            {
                if (newEndH > 0 && newEndH < Settings.MazeHeight)
                {
                    tempEndH = newEndH;
                }
            }

            //Width of end point
            if (Int32.TryParse(boxEndW.Text, out int newEndW))
            {
                if (newEndW > 0 && newEndW < Settings.MazeWidth && tempEndH != -1)
                {
                    Settings.EndPoint = new Point(tempEndH, newEndW);
                }
            }

            if (boxEndColour.Text != "")
            {
                Settings.EndPointColour = Color.FromName(boxEndColour.Text);
            }
            //Generate Maze
            //---------------------------------------------//
            Maze formMaze = new Maze();

            formMaze.Show();
        }

        private void Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Box_KeyUp(object sender, KeyEventArgs e)
        {
            if (((TextBox)sender).Name == "boxWidth")
            {
                if (Int32.TryParse(boxWidth.Text, out int temp)) { boxEndW.Text = (temp - 1).ToString(); }
                else { boxEndW.Text = ""; }
            }
            else if (((TextBox)sender).Name == "boxHeight")
            {
                if (Int32.TryParse(boxHeight.Text, out int temp)) { boxEndH.Text = (temp - 1).ToString(); }
                else { boxEndH.Text = ""; }
            }
        }
    }
}
