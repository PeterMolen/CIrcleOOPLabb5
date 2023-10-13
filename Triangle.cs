using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIrcleOOPLabb5
{
    public class Triangle : Circle // inheritance from the Circle class to this Triangle class.
    {
        public float _base;
        public float _height;

        public float _sideX;
        public float _sideY;
        public float _sideZ;

        public float _width;


        //constructor
        public Triangle(float Base, float Height)
            : base(0) //expecting an int value from the circle class, this was the best i could do, not to get an error.
        {
            _base = Base;
            _height = Height;

        }

        //constructor 2
        public Triangle(float SideX, float SideY, float SideZ)
            : base(0)
        {
            _sideX = SideX;
            _sideY = SideY;
            _sideZ = SideZ;

        }

        //constructor 3
        public Triangle()
            : base(0)
        {
            _sideX = 5;
            _width = 4;
            _height = 10;

        }

        //method 1
        public override float getArea() //metod that returns value, have Override it from the circle class
        {
            float area = _base * _height / 2; // have changeed the return value, in the body from the original method.
            return area;
        }


        public override float getCircumference() // same as above
        {
            float circumference = _sideX + _sideY + _sideZ;
            return circumference;
        }

        public override float getVolym() // same as above
        {
            float pyramidVolym = _sideX * _width * _height / 3;
            return pyramidVolym;
        }
    }
}
