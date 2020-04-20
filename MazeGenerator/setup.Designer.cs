namespace MazeGenerator
{
    partial class setup
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
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.boxWidth = new System.Windows.Forms.TextBox();
            this.boxHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxCell = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxStartH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxStartColour = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boxStartW = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.boxEndW = new System.Windows.Forms.TextBox();
            this.boxEndH = new System.Windows.Forms.TextBox();
            this.boxEndColour = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.boxGridColour = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(134, 223);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(112, 23);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Generate maze";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width:";
            // 
            // boxWidth
            // 
            this.boxWidth.Location = new System.Drawing.Point(55, 31);
            this.boxWidth.Name = "boxWidth";
            this.boxWidth.Size = new System.Drawing.Size(30, 20);
            this.boxWidth.TabIndex = 2;
            this.boxWidth.Text = "10";
            this.boxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            this.boxWidth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Box_KeyUp);
            // 
            // boxHeight
            // 
            this.boxHeight.Location = new System.Drawing.Point(55, 63);
            this.boxHeight.Name = "boxHeight";
            this.boxHeight.Size = new System.Drawing.Size(30, 20);
            this.boxHeight.TabIndex = 4;
            this.boxHeight.Text = "10";
            this.boxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            this.boxHeight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Box_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(17, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height:";
            // 
            // boxCell
            // 
            this.boxCell.Location = new System.Drawing.Point(55, 96);
            this.boxCell.Name = "boxCell";
            this.boxCell.Size = new System.Drawing.Size(30, 20);
            this.boxCell.TabIndex = 8;
            this.boxCell.Text = "30";
            this.boxCell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cell size:";
            // 
            // boxStartH
            // 
            this.boxStartH.Location = new System.Drawing.Point(54, 23);
            this.boxStartH.Name = "boxStartH";
            this.boxStartH.Size = new System.Drawing.Size(30, 20);
            this.boxStartH.TabIndex = 12;
            this.boxStartH.Text = "0";
            this.boxStartH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(12, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Coords:";
            // 
            // boxStartColour
            // 
            this.boxStartColour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxStartColour.FormattingEnabled = true;
            this.boxStartColour.Location = new System.Drawing.Point(54, 49);
            this.boxStartColour.Name = "boxStartColour";
            this.boxStartColour.Size = new System.Drawing.Size(80, 21);
            this.boxStartColour.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(15, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Colour:";
            // 
            // boxStartW
            // 
            this.boxStartW.Location = new System.Drawing.Point(90, 23);
            this.boxStartW.Name = "boxStartW";
            this.boxStartW.Size = new System.Drawing.Size(30, 20);
            this.boxStartW.TabIndex = 13;
            this.boxStartW.Text = "0";
            this.boxStartW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(5, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Start point";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.boxStartW);
            this.panel1.Controls.Add(this.boxStartH);
            this.panel1.Controls.Add(this.boxStartColour);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(190, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 80);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.boxEndW);
            this.panel2.Controls.Add(this.boxEndH);
            this.panel2.Controls.Add(this.boxEndColour);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(190, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 80);
            this.panel2.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(5, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "End point";
            // 
            // boxEndW
            // 
            this.boxEndW.Location = new System.Drawing.Point(90, 23);
            this.boxEndW.Name = "boxEndW";
            this.boxEndW.Size = new System.Drawing.Size(30, 20);
            this.boxEndW.TabIndex = 13;
            this.boxEndW.Text = "9";
            this.boxEndW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            // 
            // boxEndH
            // 
            this.boxEndH.Location = new System.Drawing.Point(54, 23);
            this.boxEndH.Name = "boxEndH";
            this.boxEndH.Size = new System.Drawing.Size(30, 20);
            this.boxEndH.TabIndex = 12;
            this.boxEndH.Text = "9";
            this.boxEndH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            // 
            // boxEndColour
            // 
            this.boxEndColour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxEndColour.FormattingEnabled = true;
            this.boxEndColour.Location = new System.Drawing.Point(54, 49);
            this.boxEndColour.Name = "boxEndColour";
            this.boxEndColour.Size = new System.Drawing.Size(80, 21);
            this.boxEndColour.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(15, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Colour:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(12, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Coords:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.boxGridColour);
            this.panel3.Controls.Add(this.boxCell);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.boxHeight);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.boxWidth);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(43, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(122, 166);
            this.panel3.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Grid";
            // 
            // boxGridColour
            // 
            this.boxGridColour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxGridColour.FormattingEnabled = true;
            this.boxGridColour.Location = new System.Drawing.Point(55, 128);
            this.boxGridColour.Name = "boxGridColour";
            this.boxGridColour.Size = new System.Drawing.Size(59, 21);
            this.boxGridColour.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Location = new System.Drawing.Point(16, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Colour:";
            // 
            // setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 272);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.panel1);
            this.Name = "setup";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxWidth;
        private System.Windows.Forms.TextBox boxHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxCell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxStartH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox boxStartColour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox boxStartW;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox boxEndW;
        private System.Windows.Forms.TextBox boxEndH;
        private System.Windows.Forms.ComboBox boxEndColour;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox boxGridColour;
        private System.Windows.Forms.Label label11;
    }
}