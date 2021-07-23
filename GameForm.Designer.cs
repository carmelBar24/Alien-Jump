namespace AlienJumpGame
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.ArenaPicture = new System.Windows.Forms.PictureBox();
            this.Alian9 = new System.Windows.Forms.PictureBox();
            this.PauseBotton = new System.Windows.Forms.PictureBox();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.Alian14 = new System.Windows.Forms.PictureBox();
            this.Alian12 = new System.Windows.Forms.PictureBox();
            this.Alian11 = new System.Windows.Forms.PictureBox();
            this.Alian20 = new System.Windows.Forms.PictureBox();
            this.Alian10 = new System.Windows.Forms.PictureBox();
            this.pointLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ArenaPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alian9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseBotton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alian14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alian12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alian11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alian20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alian10)).BeginInit();
            this.SuspendLayout();
            // 
            // ArenaPicture
            // 
            this.ArenaPicture.BackColor = System.Drawing.Color.Transparent;
            this.ArenaPicture.BackgroundImage = global::AlienJumpGame.Resource1.background;
            this.ArenaPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ArenaPicture.Location = new System.Drawing.Point(68, 0);
            this.ArenaPicture.Name = "ArenaPicture";
            this.ArenaPicture.Size = new System.Drawing.Size(384, 509);
            this.ArenaPicture.TabIndex = 0;
            this.ArenaPicture.TabStop = false;
            this.ArenaPicture.Click += new System.EventHandler(this.ArenaPicture_Click);
            this.ArenaPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_paint);
            // 
            // Alian9
            // 
            this.Alian9.BackColor = System.Drawing.Color.Transparent;
            this.Alian9.BackgroundImage = global::AlienJumpGame.Resource1.alian1;
            this.Alian9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Alian9.Location = new System.Drawing.Point(485, 111);
            this.Alian9.Name = "Alian9";
            this.Alian9.Size = new System.Drawing.Size(39, 37);
            this.Alian9.TabIndex = 2;
            this.Alian9.TabStop = false;
            // 
            // PauseBotton
            // 
            this.PauseBotton.BackColor = System.Drawing.Color.Transparent;
            this.PauseBotton.BackgroundImage = global::AlienJumpGame.Resource1.Pause_Button;
            this.PauseBotton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PauseBotton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PauseBotton.Location = new System.Drawing.Point(471, 0);
            this.PauseBotton.Name = "PauseBotton";
            this.PauseBotton.Size = new System.Drawing.Size(56, 61);
            this.PauseBotton.TabIndex = 3;
            this.PauseBotton.TabStop = false;
            this.PauseBotton.Click += new System.EventHandler(this.PauseBotton_Click);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Enabled = true;
            this.refreshTimer.Interval = 1;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // Alian14
            // 
            this.Alian14.BackColor = System.Drawing.Color.Transparent;
            this.Alian14.BackgroundImage = global::AlienJumpGame.Resource1.alian11;
            this.Alian14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Alian14.Location = new System.Drawing.Point(1, 111);
            this.Alian14.Name = "Alian14";
            this.Alian14.Size = new System.Drawing.Size(43, 40);
            this.Alian14.TabIndex = 9;
            this.Alian14.TabStop = false;
            // 
            // Alian12
            // 
            this.Alian12.BackColor = System.Drawing.Color.Transparent;
            this.Alian12.BackgroundImage = global::AlienJumpGame.Resource1.alian11;
            this.Alian12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Alian12.Location = new System.Drawing.Point(1, 405);
            this.Alian12.Name = "Alian12";
            this.Alian12.Size = new System.Drawing.Size(43, 40);
            this.Alian12.TabIndex = 10;
            this.Alian12.TabStop = false;
            // 
            // Alian11
            // 
            this.Alian11.BackColor = System.Drawing.Color.Transparent;
            this.Alian11.BackgroundImage = global::AlienJumpGame.Resource1.alian11;
            this.Alian11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Alian11.Location = new System.Drawing.Point(481, 394);
            this.Alian11.Name = "Alian11";
            this.Alian11.Size = new System.Drawing.Size(43, 40);
            this.Alian11.TabIndex = 11;
            this.Alian11.TabStop = false;
            // 
            // Alian20
            // 
            this.Alian20.BackColor = System.Drawing.Color.Transparent;
            this.Alian20.BackgroundImage = global::AlienJumpGame.Resource1.alian00;
            this.Alian20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Alian20.Location = new System.Drawing.Point(1, 253);
            this.Alian20.Name = "Alian20";
            this.Alian20.Size = new System.Drawing.Size(46, 27);
            this.Alian20.TabIndex = 12;
            this.Alian20.TabStop = false;
            // 
            // Alian10
            // 
            this.Alian10.BackColor = System.Drawing.Color.Transparent;
            this.Alian10.BackgroundImage = global::AlienJumpGame.Resource1.alian00;
            this.Alian10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Alian10.Location = new System.Drawing.Point(471, 253);
            this.Alian10.Name = "Alian10";
            this.Alian10.Size = new System.Drawing.Size(56, 27);
            this.Alian10.TabIndex = 13;
            this.Alian10.TabStop = false;
            // 
            // pointLabel
            // 
            this.pointLabel.BackColor = System.Drawing.Color.Transparent;
            this.pointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointLabel.Location = new System.Drawing.Point(-4, 0);
            this.pointLabel.Name = "pointLabel";
            this.pointLabel.Size = new System.Drawing.Size(66, 70);
            this.pointLabel.TabIndex = 14;
            this.pointLabel.Text = "0";
            this.pointLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pointLabel.Click += new System.EventHandler(this.pointLabel_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlienJumpGame.Resource1.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(529, 510);
            this.ControlBox = false;
            this.Controls.Add(this.pointLabel);
            this.Controls.Add(this.Alian10);
            this.Controls.Add(this.Alian20);
            this.Controls.Add(this.Alian11);
            this.Controls.Add(this.Alian12);
            this.Controls.Add(this.Alian14);
            this.Controls.Add(this.PauseBotton);
            this.Controls.Add(this.Alian9);
            this.Controls.Add(this.ArenaPicture);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ArenaPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alian9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseBotton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alian14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alian12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alian11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alian20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alian10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ArenaPicture;
        private System.Windows.Forms.PictureBox Alian9;
        private System.Windows.Forms.PictureBox PauseBotton;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.PictureBox Alian14;
        private System.Windows.Forms.PictureBox Alian12;
        private System.Windows.Forms.PictureBox Alian11;
        private System.Windows.Forms.PictureBox Alian20;
        private System.Windows.Forms.PictureBox Alian10;
        private System.Windows.Forms.Label pointLabel;
    }
}