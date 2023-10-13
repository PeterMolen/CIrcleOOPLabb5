using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIrcleOOPLabb5
{
    public class Circle
    {

        public float Pi { get; set; }
        public int Radius { get; set; }


        //constructor
        public Circle(int radius)
        {
            Radius = radius;
            Pi = 3.141f;

        }

        //method 1
        public virtual float getArea() //metod som retunerar
        {
            float area = Radius * Radius * Pi;
            return area;
        }

        public void PrintArea() // method that is printingData not returnnig a value, for test usesage only.
        {
            float area = Radius * Radius * Pi;
            Console.WriteLine("arean av din ◙ är: {0} ", area + " m2");
        }

        public virtual float getCircumference()
        {
            float circumference = Radius + Radius * Pi;
            return circumference;
        }

        public virtual float getVolym()
        {
            float sphereVolym = 4 * Pi * Radius * Radius * Radius / 3;
            return sphereVolym;
        }

        public void PartitionCode() //make output in the console look a bit smoother for the eye
        {
            Console.WriteLine("_______________________________________");
        }
    }
}
