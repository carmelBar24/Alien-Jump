using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlienJumpGame
{
    public partial class MenuForm : Form
    {
        int steps = 0;
        public MenuForm()
        {
            InitializeComponent();
        }

       

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        

        private void HelpBottom_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlayBottom_Click(object sender, EventArgs e)
        {
         GameForm game = new GameForm(this);
           game.Show();
        }

        private void DoodleJump_Click(object sender, EventArgs e)
        {

        }

        private void AlianJump_Click(object sender, EventArgs e)
        {

        }

        private void Alian6_Click(object sender, EventArgs e)
        {

        }

        private void MenuTimer_Tick(object sender, EventArgs e)
        {
            if (steps < 15)
            {
                DoodleJump.Top -=6;
                steps++;
            }
            else
            {
                DoodleJump.Top += 6;
                steps++;
                if (steps == 30)
                    steps = 0;
            }

        }
    }
}
