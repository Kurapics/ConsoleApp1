using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Solution
    {
        private double x;
        private double y;

        public Solution(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }

        public string GetTopSolution()
        {
            if (x >= 0 && x <= 1 && y >= 0 + Math.Abs(x) && y <= 1 && y >= 0) return "Попадает";
            else return "Не попадает";
        }
        public string GetBottomSolution()
        {
            if (x >= 0 && x <= 1 && y >= 0 - Math.Abs(x) && y <= 0 && y >= -1) return "Попадает";
            else return "Не попадает";
        }
        public string GetZeroSolution()
        {
            if (x == 0 && y == 0) return "Попадает";
            else return "Не попадает";
        }
    }
}
