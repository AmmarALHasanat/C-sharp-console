using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.OOP.Encapsulation
{
    internal class Point
    {
        private double _x;
        private double _y;

        //public double X { get { return _x; } set { _x = value; } }
        public double getX()
        {
           return _x;
        }
        public double getY()
        {
            return _y;
        }

        public void setX(double x)
        {
            _x = x;
        }

        public void setY(double y)
        {
            _y = y;
        }

        public override string ToString()
        {
            return $"x = {_x}\ty = {_y}";
        }


    }
}
