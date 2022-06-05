using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculator
{
    internal class Point
    {
        int x, y;
        string name;   
        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public int GetX { get { return x; }}
        public int GetY { get { return y; }}
        public string Name { get { return name; }}
    }
}
