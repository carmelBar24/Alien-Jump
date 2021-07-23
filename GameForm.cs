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
    public partial class GameForm : Form
    {
        Manager myManager;
        MenuForm menu;
        public GameForm(MenuForm menu)
        {
            InitializeComponent();
            this.myManager = new Manager(ArenaPicture.Size,this);
            this.menu = menu;
        }

        private void PauseBotton_Click(object sender, EventArgs e)
        {
            PauseForm pause = new PauseForm(this.menu);
            pause.Show();
        }
        private void pictureBox1_paint(object sender, PaintEventArgs e)
        {
            this.myManager.ShowAllElemenets(e);
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            ArenaPicture.Refresh();
            pointLabel.Text = this.myManager.Getpoint().ToString();
        }

        private void ArenaPicture_Click(object sender, EventArgs e)
        {
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            this.myManager.Move(e.KeyCode);
        }

        private void pointLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

