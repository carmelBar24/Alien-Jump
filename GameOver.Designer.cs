namespace AlienJumpGame
{
    partial class GameOverForm
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
            this.GameOver = new System.Windows.Forms.PictureBox();
            this.GameOverF = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hight = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOverF)).BeginInit();
            this.SuspendLayout();
            // 
            // GameOver
            // 
            this.GameOver.BackColor = System.Drawing.Color.Transparent;
            this.GameOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameOver.Image = global::AlienJumpGame.Resource1.game_over;
            this.GameOver.Location = new System.Drawing.Point(115, 100);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(288, 95);
            this.GameOver.TabIndex = 0;
            this.GameOver.TabStop = false;
            // 
            // GameOverF
            // 
            this.GameOverF.BackColor = System.Drawing.Color.Transparent;
            this.GameOverF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameOverF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameOverF.Image = global::AlienJumpGame.Resource1.menu_button;
            this.GameOverF.Location = new System.Drawing.Point(183, 357);
            this.GameOverF.Name = "GameOverF";
            this.GameOverF.Size = new System.Drawing.Size(118, 41);
            this.GameOverF.TabIndex = 1;
            this.GameOverF.TabStop = false;
            this.GameOverF.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(52, 236);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(80, 25);
            this.Score.TabIndex = 2;
            this.Score.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your hight score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // hight
            // 
            this.hight.AutoSize = true;
            this.hight.BackColor = System.Drawing.Color.Transparent;
            this.hight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hight.Location = new System.Drawing.Point(248, 289);
            this.hight.Name = "hight";
            this.hight.Size = new System.Drawing.Size(0, 25);
            this.hight.TabIndex = 6;
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(125, 236);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(89, 32);
            this.scoreLabel.TabIndex = 7;
            // 
            // GameOverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlienJumpGame.Resource1.background;
            this.ClientSize = new System.Drawing.Size(521, 502);
            this.ControlBox = false;
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.hight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.GameOverF);
            this.Controls.Add(this.GameOver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "GameOverForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameOverForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOverF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GameOver;
        private System.Windows.Forms.PictureBox GameOverF;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label hight;
        private System.Windows.Forms.Label scoreLabel;
    }
}