namespace AlienJumpGame
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.Brick1 = new System.Windows.Forms.PictureBox();
            this.BlueBrick = new System.Windows.Forms.PictureBox();
            this.BrownBrick = new System.Windows.Forms.PictureBox();
            this.WhiteBrick = new System.Windows.Forms.PictureBox();
            this.Point = new System.Windows.Forms.PictureBox();
            this.Help = new System.Windows.Forms.PictureBox();
            this.MenuBotton = new System.Windows.Forms.PictureBox();
            this.Normal1 = new System.Windows.Forms.Label();
            this.Brake = new System.Windows.Forms.Label();
            this.Normal3 = new System.Windows.Forms.Label();
            this.ExtraP = new System.Windows.Forms.Label();
            this.Normal2 = new System.Windows.Forms.Label();
            this.helpLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Brick1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBrick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrownBrick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteBrick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBotton)).BeginInit();
            this.SuspendLayout();
            // 
            // Brick1
            // 
            this.Brick1.BackColor = System.Drawing.Color.Transparent;
            this.Brick1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Brick1.Image = global::AlienJumpGame.Resource1.green;
            this.Brick1.Location = new System.Drawing.Point(50, 123);
            this.Brick1.Name = "Brick1";
            this.Brick1.Size = new System.Drawing.Size(76, 22);
            this.Brick1.TabIndex = 1;
            this.Brick1.TabStop = false;
            // 
            // BlueBrick
            // 
            this.BlueBrick.BackColor = System.Drawing.Color.Transparent;
            this.BlueBrick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BlueBrick.Image = global::AlienJumpGame.Resource1.blue;
            this.BlueBrick.Location = new System.Drawing.Point(50, 162);
            this.BlueBrick.Name = "BlueBrick";
            this.BlueBrick.Size = new System.Drawing.Size(76, 22);
            this.BlueBrick.TabIndex = 2;
            this.BlueBrick.TabStop = false;
            // 
            // BrownBrick
            // 
            this.BrownBrick.BackColor = System.Drawing.Color.Transparent;
            this.BrownBrick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BrownBrick.Image = global::AlienJumpGame.Resource1.red_original;
            this.BrownBrick.Location = new System.Drawing.Point(50, 208);
            this.BrownBrick.Name = "BrownBrick";
            this.BrownBrick.Size = new System.Drawing.Size(76, 20);
            this.BrownBrick.TabIndex = 3;
            this.BrownBrick.TabStop = false;
            // 
            // WhiteBrick
            // 
            this.WhiteBrick.BackColor = System.Drawing.Color.Transparent;
            this.WhiteBrick.BackgroundImage = global::AlienJumpGame.Resource1.white;
            this.WhiteBrick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WhiteBrick.Location = new System.Drawing.Point(50, 251);
            this.WhiteBrick.Name = "WhiteBrick";
            this.WhiteBrick.Size = new System.Drawing.Size(76, 19);
            this.WhiteBrick.TabIndex = 4;
            this.WhiteBrick.TabStop = false;
            // 
            // Point
            // 
            this.Point.BackColor = System.Drawing.Color.Transparent;
            this.Point.Image = global::AlienJumpGame.Resource1.coin;
            this.Point.Location = new System.Drawing.Point(50, 303);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(36, 19);
            this.Point.TabIndex = 7;
            this.Point.TabStop = false;
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.Transparent;
            this.Help.Image = global::AlienJumpGame.Resource1.help111;
            this.Help.Location = new System.Drawing.Point(50, 12);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(203, 96);
            this.Help.TabIndex = 9;
            this.Help.TabStop = false;
            // 
            // MenuBotton
            // 
            this.MenuBotton.BackColor = System.Drawing.Color.Transparent;
            this.MenuBotton.BackgroundImage = global::AlienJumpGame.Resource1.menu_button;
            this.MenuBotton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuBotton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuBotton.Location = new System.Drawing.Point(383, 454);
            this.MenuBotton.Name = "MenuBotton";
            this.MenuBotton.Size = new System.Drawing.Size(137, 40);
            this.MenuBotton.TabIndex = 10;
            this.MenuBotton.TabStop = false;
            this.MenuBotton.Click += new System.EventHandler(this.MenuBotton_Click);
            // 
            // Normal1
            // 
            this.Normal1.AutoSize = true;
            this.Normal1.BackColor = System.Drawing.Color.Transparent;
            this.Normal1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Normal1.Location = new System.Drawing.Point(152, 124);
            this.Normal1.Name = "Normal1";
            this.Normal1.Size = new System.Drawing.Size(101, 18);
            this.Normal1.TabIndex = 11;
            this.Normal1.Text = "Normal brick";
            // 
            // Brake
            // 
            this.Brake.AutoSize = true;
            this.Brake.BackColor = System.Drawing.Color.Transparent;
            this.Brake.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brake.Location = new System.Drawing.Point(152, 208);
            this.Brake.Name = "Brake";
            this.Brake.Size = new System.Drawing.Size(57, 18);
            this.Brake.TabIndex = 12;
            this.Brake.Text = "breaks";
            // 
            // Normal3
            // 
            this.Normal3.AutoSize = true;
            this.Normal3.BackColor = System.Drawing.Color.Transparent;
            this.Normal3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Normal3.Location = new System.Drawing.Point(152, 251);
            this.Normal3.Name = "Normal3";
            this.Normal3.Size = new System.Drawing.Size(101, 18);
            this.Normal3.TabIndex = 13;
            this.Normal3.Text = "Normal brick";
            // 
            // ExtraP
            // 
            this.ExtraP.AutoSize = true;
            this.ExtraP.BackColor = System.Drawing.Color.Transparent;
            this.ExtraP.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraP.Location = new System.Drawing.Point(148, 303);
            this.ExtraP.Name = "ExtraP";
            this.ExtraP.Size = new System.Drawing.Size(93, 18);
            this.ExtraP.TabIndex = 16;
            this.ExtraP.Text = "extra points";
            // 
            // Normal2
            // 
            this.Normal2.AutoSize = true;
            this.Normal2.BackColor = System.Drawing.Color.Transparent;
            this.Normal2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Normal2.Location = new System.Drawing.Point(152, 162);
            this.Normal2.Name = "Normal2";
            this.Normal2.Size = new System.Drawing.Size(101, 36);
            this.Normal2.TabIndex = 17;
            this.Normal2.Text = "Normal brick\r\n\r\n";
            // 
            // helpLable
            // 
            this.helpLable.AutoSize = true;
            this.helpLable.BackColor = System.Drawing.Color.Transparent;
            this.helpLable.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpLable.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.helpLable.Location = new System.Drawing.Point(277, 12);
            this.helpLable.Name = "helpLable";
            this.helpLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.helpLable.Size = new System.Drawing.Size(246, 288);
            this.helpLable.TabIndex = 18;
            this.helpLable.Text = resources.GetString("helpLable.Text");
            this.helpLable.Click += new System.EventHandler(this.helpLable_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlienJumpGame.Resource1.background;
            this.ClientSize = new System.Drawing.Size(535, 516);
            this.ControlBox = false;
            this.Controls.Add(this.helpLable);
            this.Controls.Add(this.Normal2);
            this.Controls.Add(this.ExtraP);
            this.Controls.Add(this.Normal3);
            this.Controls.Add(this.Brake);
            this.Controls.Add(this.Normal1);
            this.Controls.Add(this.MenuBotton);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.WhiteBrick);
            this.Controls.Add(this.BrownBrick);
            this.Controls.Add(this.BlueBrick);
            this.Controls.Add(this.Brick1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelpForm";
            ((System.ComponentModel.ISupportInitialize)(this.Brick1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBrick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrownBrick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteBrick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBotton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Brick1;
        private System.Windows.Forms.PictureBox BlueBrick;
        private System.Windows.Forms.PictureBox BrownBrick;
        private System.Windows.Forms.PictureBox WhiteBrick;
        private System.Windows.Forms.PictureBox Point;
        private System.Windows.Forms.PictureBox Help;
        private System.Windows.Forms.PictureBox MenuBotton;
        private System.Windows.Forms.Label Normal1;
        private System.Windows.Forms.Label Brake;
        private System.Windows.Forms.Label Normal3;
        private System.Windows.Forms.Label ExtraP;
        private System.Windows.Forms.Label Normal2;
        private System.Windows.Forms.Label helpLable;

    }
}