using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace AlienJumpGame
{
    class Bricks
    {
        private TypeBrick type; //סוג הלבנה
        private Image image; //התמונה של האוביקט
        private Rectangle rectangle;//המלבן של האובייקט


        public Bricks(int x, int y, TypeBrick type) // פעולה שמקבלת מיקום וסוג הלבנה
        {
         
            this.type = type;
            switch (this.type)
            {
                case TypeBrick.Green: this.image = Resource1.green; break;
                case TypeBrick.White: this.image = Resource1.white; break;
                case TypeBrick.Blue: this.image = Resource1.blue; break;
                case TypeBrick.brown: this.image = Resource1.red_original; break;
                case TypeBrick.bonus: this.image = Resource1.coin; break; 
            }
            this.rectangle = new Rectangle(x, y, 50, 20);
        }
        public void ShowMe(PaintEventArgs e) //פעולה שתציג את האריחים על המסך
        {
            if (this.image != null)
                e.Graphics.DrawImage(this.image, this.rectangle);

        }
        public RectangleF GetRectangle()
        {
            return this.rectangle;
        }

        public TypeBrick GetBonus()
        {
            return TypeBrick.bonus;

        }
        public void SetTypeBrick(TypeBrick type)
        {
            this.type = type;
        }
        public void MoveDown()
        {
            this.rectangle.Y += 50;
        }
        public TypeBrick GetTypeBrick()
        {
            return this.type;
        }

        internal void ChangeType()
        {
            this.image = Resource1.red_broken_png1;

        }
    }
    public enum TypeBrick
    {
        Green, White, Blue, brown,bonus,
    }
}

