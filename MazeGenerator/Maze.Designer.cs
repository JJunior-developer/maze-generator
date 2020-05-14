namespace MazeGenerator
{
    partial class Maze
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mazePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // mazePanel
            // 
            this.mazePanel.AutoSize = true;
            this.mazePanel.Location = new System.Drawing.Point(10, 10);
            this.mazePanel.Name = "mazePanel";
            this.mazePanel.Size = new System.Drawing.Size(760, 760);
            this.mazePanel.TabIndex = 0;
            this.mazePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            // 
            // Maze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 771);
            this.Controls.Add(this.mazePanel);
            this.Name = "Maze";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.MazePanel_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mazePanel;
    }
}

