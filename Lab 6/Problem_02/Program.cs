using System;
using System.Collections.Generic;
using System.Threading;
using Problem_02.BL;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] plane = new char[4, 7]
            {
                { ' ', ' ', ' ', '^', ' ', ' ', ' ' },
                { ' ', ' ', '^', '^', '^', ' ', ' ' },
                { ' ', '^', '^', '^', '^', '^', ' ' },
                { '^', '^', '^', '^', '^', '^', '^' }
            };
            char[,] opPlane = new char[4, 7]
            {
                { '^', '^', '^', '^', '^', '^', '^' },
                { ' ', '^', '^', '^', '^', '^', ' ' },
                { ' ', ' ', '^', '^', '^', ' ', ' ' },
                { ' ', ' ', ' ', '^', ' ', ' ', ' ' }
            };
            Boundary boundary = new Boundary(
                new Point(0, 0),
                new Point(0, 90),
                new Point(90, 0),
                new Point(90, 90)
            );
            GameObject g1 = new GameObject(plane, new Point(5, 5), boundary, "LeftToRight");
            GameObject g2 = new GameObject(opPlane, new Point(5, 5), boundary, "RightToLeft");
            List<GameObject> objects = new List<GameObject>();
            objects.Add(g1);
            objects.Add(g2);
            while (true)
            {
                Thread.Sleep(500);
                foreach (GameObject obj in objects)
                {
                    obj.eraseObject();
                    obj.moveObject();
                    obj.drawObject();
                }
            }
        }
    }
}
