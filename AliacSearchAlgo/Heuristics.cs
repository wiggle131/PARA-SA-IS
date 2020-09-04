using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AISearchSample;
using System.Collections;

namespace AliacSearchAlgo
{
     class Heuristics
    {
        double val;
        int x;
        int y;

        public Heuristics()
        {
            this.val = 0;
            this.x = 0;
            this.y = 0;
        }
        public double calculate(Node start, Node goal)
        {
            x=Math.Abs((start.X)-(goal.X));
            y=Math.Abs((start.Y) - (goal.Y));
            val = Math.Sqrt((x * x) + (y * y));   
           return val;

        }

        internal double calculate(Node node)
        {
            throw new NotImplementedException();
        }
    }
}
