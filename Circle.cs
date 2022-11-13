using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK1PA_exercises
{
    internal class Circle
    {
        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }


        public double CircleCircum ()
        {
            return Math.Round((Math.PI * Radius * 2),2);
        }

        public double CircleArea ()
        {
            return Math.Round(((Math.PI * Radius * Radius) / 4),2);
        }
    }
}
