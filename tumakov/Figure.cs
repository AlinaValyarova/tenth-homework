using System;
using System.Collections.Generic;
using System.Text;

namespace tumakov
{

    public class Figure: IColour, IMove
    {
        public string colour;
        public string place;
        public enum Visibility : byte
        {
            visible,
            invisible
        }

        public void ChangeColour(Figure figure)
        {
            string[] colours = { "red", "white", "blue" };
            Console.WriteLine("Now figure is {0}", figure.colour);
            Console.WriteLine("What colour do you want it to change to?");
            string a = Console.ReadLine();
            if (Array.Exists(colours, element => element == a))
            {
                figure.colour = a;
                Console.WriteLine("Changed successfully");
            }
            else
            {
                Console.WriteLine("You entered something wrong. Fail!");
            }
        }

        public void Horizontally(Figure figure)
        {
            if (figure.place.ToLower().Equals("right"))
            {
                Console.WriteLine("Now figure is on the left side");
            }

            else
            {
                Console.WriteLine("Now figure is on the right side");
            }
        }

        public void Vertically(Figure figure)
        {
            if (figure.place.ToLower().Equals("top"))
            {
                Console.WriteLine("Now figure is at the bottom");
            }

            else
            {
                Console.WriteLine("Now figure is on top");
            }
        }


        public class Point : Figure
        {
            class Circle : Point
            {

                public static double AreaOfCircle(int rad)
                {
                    return rad * rad * Math.PI;
                }
            }

            class Rectangle: Point
            {
                public static double AreaOfRectangle(int a)
                {
                    return a * a;
                }
            }

        }
    }
}
