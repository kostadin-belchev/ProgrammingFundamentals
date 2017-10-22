using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Rectangle_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = ReadRectangle();
            Rectangle r2 = ReadRectangle();

            if (r1.IsInside(r2))
                Console.WriteLine("Inside");
            else
                Console.WriteLine("Not inside");
        }

        public static Rectangle ReadRectangle()
        {
            int[] leftTopWidthHeight = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Rectangle r = new Rectangle() { Left = leftTopWidthHeight.First(), Top = leftTopWidthHeight.Skip(1).First(), Width = leftTopWidthHeight.Skip(2).First(), Height = leftTopWidthHeight.Last() };
            return r;
        }

        public class Rectangle
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            public int Botton
            {
                get
                {
                    return Top + Height;
                }
            }

            public int Right
            {
                get
                {
                    return Left + Width;
                }
            }

            

            public bool IsInside(Rectangle other) ////What out with the private statement
            {
                var isInLeft = this.Left >= other.Left;
                var isInRight = this.Right <= other.Right;
                var isInTop = this.Top >= other.Top;
                var isInBottom = this.Botton <= other.Botton;

                var isInsideHorizontal = isInLeft && isInRight;
                var isInsideVertical = isInTop && isInBottom;

                return isInsideHorizontal && isInsideVertical;
            }
        }
    }
}
