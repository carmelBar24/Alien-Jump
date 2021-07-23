using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AlienJumpGame
{
    public partial class GameOverForm : Form
    {
        private GameForm game;
        public GameOverForm(GameForm game,int point)
        {
            InitializeComponent();
            this.game = game;
            this.scoreLabel.Text = point.ToString();
            StreamReader sr = new StreamReader("..\\..\\Resources\\HightScore.txt");
            int score = int.Parse(sr.ReadLine());
            sr.Close();
            hight.Text = score.ToString();
            if (point > score)
            {
                StreamWriter sw = new StreamWriter("..\\..\\Resources\\HightScore.txt");
                sw.WriteLine(point.ToString());
                sw.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.game.Close();
            this.Close();
        }
    }
}
