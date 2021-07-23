using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlienJumpGame
{
    class Manager
    {
        static Random rnd = new Random();
        private DoodleJump alien;
        private List<Bricks> bricks;
        private Timer addBrickTimer; //טיימר שיצור אריחים
        private Timer pauseTimer;
        private Timer touchBonus;
        private Size arenaSize;
        private int deleteBrick;
        private  int Point;
        private GameForm game;
        private Bricks bonus;
        public Manager(Size arenaSize,GameForm game)
        {
            this.arenaSize = arenaSize;
            this.game = game;
            this.Point = 0;
            this.alien = new DoodleJump(arenaSize);
            this.alien.IsJump += new EventHandler(alien_IsJump);
            this.bricks = new List<Bricks>();
            this.bricks.Add(new Bricks(1, arenaSize.Height-20, TypeBrick.Blue));
            this.bricks.Add(new Bricks(40, arenaSize.Height - 20, TypeBrick.Blue));
            this.bricks.Add(new Bricks(80, arenaSize.Height - 20, TypeBrick.Blue));
            this.bricks.Add(new Bricks(120, arenaSize.Height - 20, TypeBrick.Blue));
            this.bricks.Add(new Bricks(160, arenaSize.Height - 20, TypeBrick.Blue));
            this.bricks.Add(new Bricks(200, arenaSize.Height - 20, TypeBrick.Blue));
            this.bricks.Add(new Bricks(240, arenaSize.Height - 20, TypeBrick.Blue));
            this.bricks.Add(new Bricks(280, arenaSize.Height - 20, TypeBrick.Blue));
            this.bricks.Add(new Bricks(320, arenaSize.Height - 20, TypeBrick.Blue));
            this.bricks.Add(new Bricks(360, arenaSize.Height - 20, TypeBrick.Blue));
          
            this.bricks.Add(new Bricks(( arenaSize.Width - 100), arenaSize.Height -280, TypeBrick.brown));
            //this.bricks.Add(new Bricks(, arenaSize.Height - 100, Type.Green));
            this.bricks.Add(new Bricks(( arenaSize.Width - 300), arenaSize.Height -100, TypeBrick.White));
            this.bricks.Add(new Bricks((arenaSize.Width - 200), arenaSize.Height - 150, TypeBrick.Blue));
            this.bricks.Add(new Bricks((arenaSize.Width -320), arenaSize.Height - 250, TypeBrick.Green));
            //this.bricks.Add(new Bricks(rnd.Next(0, arenaSize.Width - 30), arenaSize.Height - 150, Type.White));
            this.addBrickTimer = new Timer();
            this.addBrickTimer.Enabled = false;
            this.addBrickTimer.Interval = 300;
            this.pauseTimer = new Timer();
            this.pauseTimer.Enabled = false;
            this.pauseTimer.Interval = 500;
            this.pauseTimer.Tick += new EventHandler(pauseTimer_Tick);
            this.addBrickTimer.Tick += new EventHandler(addBrickTimer_Tick);
            touchBonus = new Timer();
            touchBonus.Enabled = true;
            touchBonus.Interval = 1;
            touchBonus.Tick += new EventHandler(touchBonus_Tick);
        }

        void touchBonus_Tick(object sender, EventArgs e)
        {
            if(bonus!=null)
            if (alien.GetRectangle().IntersectsWith(bonus.GetRectangle()))
            {
                bonus = null;
                Point += 50;

            }
        }
        
        void pauseTimer_Tick(object sender, EventArgs e)
        {
            this.bricks.RemoveAt(deleteBrick);
            this.pauseTimer.Enabled = false;
        }   

        void alien_IsJump(object sender, EventArgs e)
        {
            for (int i = 0; i < this.bricks.Count; i++)
                if (this.bricks[i].GetRectangle().IntersectsWith(this.alien.GetRectangle()) == true)
                {
                    if (this.bricks[i].GetTypeBrick() == TypeBrick.brown)
                    {
                        this.deleteBrick = i;
                        this.bricks[i].ChangeType();
                        this.pauseTimer.Enabled = true;  
                    }
                    else
                    {
                        this.alien.Jump();
                        AllBricksDown();
                        AddBrick();
                    }
                }
            if (this.alien.GetRectangle().Bottom >= arenaSize.Height)
            {
                this.alien.IsJump -= new EventHandler(alien_IsJump);
              
                GameOverForm over = new GameOverForm(this.game,this.Point);
                over.Show();
            }
        }

        public int Getpoint()
        {
            return Point;
        }


        private void AllBricksDown()
        {
            for (int i = 0; i < this.bricks.Count; i++)
                this.bricks[i].MoveDown();
            if (this.bonus != null)
                this.bonus.MoveDown();
            this.Point += 50;
        }
        public void AddBrick()
        {
            int num = rnd.Next(1, 6);
            int x=rnd.Next(0, arenaSize.Width - 50);
            this.bricks.Add(new Bricks(x, 100, (TypeBrick)rnd.Next(4)));
            if (num == 5)
                bonus = new Bricks(x, 80, TypeBrick.bonus);

            
            
        }
        void addBrickTimer_Tick(object sender, EventArgs e)
        {
            AddBrick();
        }
        
        public void ShowAllElemenets(PaintEventArgs e)
        {
            this.alien.ShowMe(e);
            for (int i = 0; i < this.bricks.Count; i++)
                this.bricks[i].ShowMe(e);
            if (bonus != null)
            {
                bonus.ShowMe(e);
            }
        }


        internal void Move(Keys keys)
        {
            switch (keys)
            {
                case Keys.Right: this.alien.moveRight(); break;
                case Keys.Left: this.alien.moveLeft(); break; 
                case Keys.Up: this.alien.Jump(); break;
            }
        }     
    }
}
