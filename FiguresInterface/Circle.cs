using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresInterface
{
    internal class Circle : IDrawable
    {

        private int radius;

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public void Draw()
        {
            DrawLine(this.Radius, '*', '*');
            for (int i = 1; i < this.Radius - 1; ++i)
                DrawLine(this.Radius, '*', ' ');
            DrawLine(this.Radius, '*', '*');

        }
        private void DrawLine(int width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width - 1; ++i)
                Console.Write(mid);
            Console.WriteLine(end);
        }

        public Circle(int radius)
        {
            this.radius = radius;
        }

    }
}