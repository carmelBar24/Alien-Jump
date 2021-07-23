using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace AlienJumpGame
{
    class DoodleJump
    {
        private float maxX = 3;
        private float maxY = 3;
        private Image image;//תמונת הדמות 
        //private Image left; //התמונה של הדמות פונה לצד שמאל
        private RectangleF rectangle; //מלבן שחוסם את הדמות
        private StateType state; //המצב של הדמות
        private Size arenaSize; //גודל המסך של המשחק
        private Timer jumpTimer; //טיימר לקפיצה
        private int jumptime; //התאוצה
        private Timer moveTimer; //אחראי לתנועה של הדמות מימינה לשמאלה
                                 //public event EventHandler GameOver; //הגדרת אירוע שבו הדמות מגיעה לסוף המסך
        private float dy; // מהירות שהדמות יורדת
        public event EventHandler IsJump;
       
        public DoodleJump(Size arenaSize)
        {
            
            this.rectangle = new Rectangle(2, 2, Resource1.doodle_left_green1.Width-10, Resource1.doodle_left_green1.Height-10);
            this.state = StateType.rest;
            this.arenaSize = arenaSize;
            this.image = Resource1.doodle_right_green1;
           
            this.dy = 2;
            //התזוזה ימינה שמאלה
            this.moveTimer = new Timer();
            this.moveTimer.Enabled = true;
            this.moveTimer.Interval = 1;
            this.moveTimer.Tick += MoveTimer_Tick;
            //הקפיצה
            this.jumptime = 1;
            this.jumpTimer = new Timer();
            this.jumpTimer.Enabled = false;
            this.jumpTimer.Interval = 30;
            //this.jumpTimer.Tick += JumpTimer_Tick; 
            
        }

        //private void JumpTimer_Tick(object sender, EventArgs e)
        //{
        //    if(this.rectangle.Y>5)
        //   this.dy =-3;
        //}
        public void Jump()
        {
            if(this.rectangle.Top>7)
            this.dy = -20;
            //this.rectangle.Y = 2F;
        }
        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            this.rectangle.Y += this.dy;
            this.dy += 0.15F;
            if(IsJump!=null)
            IsJump(null, null);
            //if (this.rectangle.Bottom >= this.arenaSize.Height)
            //    this.Jump();
            if (this.rectangle.Y <= 0)
                this.dy=5;

        }
        public void moveRight()
        {
            this.state = StateType.right;
            this.rectangle.X += 10;
            if (this.rectangle.Right>=arenaSize.Width)
                this.moveLeft();
            
            
        }
        public void moveLeft()
        {
            this.state = StateType.left;
            this.rectangle.X += -10;
            if (this.rectangle.Left<=0)
               this.moveRight();

        }
        public RectangleF GetRectangle()
        {
            return this.rectangle;
        }
        public void ShowMe(PaintEventArgs e)
        {
            switch (this.state)
            {
                case StateType.rest: this.image = Resource1.doodle_right_green1; break;
                case StateType.right: this.image = Resource1.doodle_right_green1; break;
                case StateType.left: this.image = Resource1.doodle_left_green1; break;

            }
            e.Graphics.DrawImage(this.image, this.rectangle);
        }
        public enum StateType
        {
            rest, left, right,
        }

    }
}
