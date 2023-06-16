using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problem_02.BL
{
    public class GameObject
    {
        public char[,] obj;
        private Point Starting_Point;
        private Boundary Premises;
        private string Direction;

        // private List<int> objectLength = new List<int>();
        public int rows = 0;
        public int cols = 0;
        public int moving = 0;

        public string Get_Direction()
        {
            return this.Direction;
        }

        public GameObject()
        {
            this.obj = new char[1, 3]
            {
                { '*', '*', '*' }
            };
            this.Starting_Point = new Point(0, 0);
            this.Premises = new Boundary(
                new Point(0, 0),
                new Point(0, 90),
                new Point(90, 0),
                new Point(90, 90)
            );
            this.Direction = "LeftToRight";
        }

        public GameObject(char[,] obj, Point Starting_Point)
        {
            this.obj = obj;
            this.Starting_Point = Starting_Point;
            this.Premises = new Boundary(
                new Point(0, 0),
                new Point(0, 90),
                new Point(90, 0),
                new Point(90, 90)
            );
            this.Direction = "LeftToRight";
        }

        public GameObject(char[,] obj, Point Starting_Point, Boundary Premises, string Direction)
        {
            this.obj = obj;
            this.Starting_Point = Starting_Point;
            this.Premises = Premises;
            this.Direction = Direction;
        }

        public void moveObject()
        {
            string dir = Get_Direction();
            int x = Starting_Point.getX();
            int y = Starting_Point.getY();

            if (dir == "LeftToRight")
            {
                if (x < Premises.get_Bottom_Right().getX())
                {
                    x++;
                    Starting_Point.setX(x);
                }
            }
            else if (dir == "RightToLeft")
            {
                if (x > Premises.get_Top_Left().getX() && y < Premises.get_Top_Right().getY())
                {
                    x--;
                    Starting_Point.setXY(x, y);
                }
            }
            else if (dir == "Patrol")
            {
                if (x > Premises.get_Top_Left().getX())
                {
                    x--;
                    Starting_Point.setXY(x, y);
                }
                else if (x <= Premises.get_Top_Left().getX())
                {
                    dir = "LeftToRight";
                }
                Direction = dir;
            }
            else if (dir == "Projectile")
            {
                if (moving < 9)
                {
                    if (y <= Premises.get_Top_Right().getY() && moving < 5)
                    {
                        y--;
                    }
                    else if (y <= Premises.get_Bottom_Right().getY() && moving >= 5)
                    {
                        y++;
                    }
                    x++;
                    moving++;
                    Starting_Point.setXY(x, y);
                }
            }
            else if (dir == "Diagonal")
            {
                x++;
                y++;
                Starting_Point.setXY(x, y);

                if (x > Premises.get_Bottom_Right().getX())
                {
                    dir = "LeftToRight";
                    Direction = dir;
                    Starting_Point.setX(x);
                }
            }
        }

        public void eraseObject()
        {
            Console.SetCursorPosition(Starting_Point.getX(), Starting_Point.getY());
            for (int i = 0; i < this.obj.GetLength(0); i++)
            {
                for (int j = 0; j < this.obj.GetLength(1); j++)
                {
                    Console.Write(" ");
                }
                Console.SetCursorPosition(Starting_Point.getX(), Starting_Point.getY() + i + 1);
            }
        }

        public void drawObject()
        {
            Console.SetCursorPosition(Starting_Point.getX(), Starting_Point.getY());
            for (int i = 0; i < this.obj.GetLength(0); i++)
            {
                for (int j = 0; j < this.obj.GetLength(1); j++)
                {
                    Console.Write(this.obj[i, j]);
                }
                Console.SetCursorPosition(Starting_Point.getX(), Starting_Point.getY() + i + 1);
            }
        }
    }
}
