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
    public partial class PauseForm : Form
    {
        MenuForm menu;
        public PauseForm(MenuForm menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuBottom_Click(object sender, EventArgs e)
        {
            this.menu.Activate();
            this.Close();
        }
    }
}
