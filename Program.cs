using System;
using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace CIrcleOOPLabb5
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // ⬤ 〇  ⬤ 〇  ⬤ 〇  ⬤ 〇  ⬤ 〇  ⬤ 〇 ⬤ 〇  ⬤ 〇 ⬤ 〇  ⬤ 〇 ⬤ 〇  ⬤ 〇 // begining of circle part

            Circle radius5 = new Circle(5); //object of Circl radius 5
            Circle radius6 = new Circle(6); //object of Circl radius 6
            float circle1 = radius5.getArea(); //Call the method to get circleArea 
            Console.WriteLine("arean av din ◙ är: " + circle1 + " m2"); // Printing out the reuslt as a ReturnValue
            float circle2 = radius6.getArea();
            Console.WriteLine("arean av din ◙ är: " + circle2 + " m2");

            Console.WriteLine(); // just to make the code in console look better with a gap

            Console.WriteLine(" (OBS) inte upprepning av kod bara ett test:");
            radius5.PrintArea(); // just trying a mehtod to print a strnig without to return a value
            radius6.PrintArea(); // not repeat of code just a try.

            radius5.PartitionCode(); //Calling a meothd to print out __ underscore to make the code look more good in console.
            Console.WriteLine();

            //_____________________________________________________________

            float circle3 = radius5.getCircumference();
            Console.WriteLine("omkretsen av din ◙ är: " + circle3 + " cm");
            float circle4 = radius6.getCircumference();
            Console.WriteLine("omkretsen av din ◙ är: " + circle4 + " cm");

            radius5.PartitionCode();
            Console.WriteLine();


            float circle5 = radius5.getVolym();
            Console.WriteLine("volymen av din ◙ är: " + circle5 + " cm3");
            float circle6 = radius6.getVolym();
            Console.WriteLine("volymen av din ◙ är: " + circle6 + " cm3");


            radius5.PartitionCode();
            Console.WriteLine();
            // ⬤ 〇  ⬤ 〇  ⬤ 〇  ⬤ 〇  ⬤ 〇  ⬤ 〇 ⬤ 〇  ⬤ 〇 ⬤ 〇  ⬤ 〇 ⬤ 〇  ⬤ 〇 //end of circle part


            // ◭ 🔻  ◭ 🔻	◭ 🔻   ◭ 🔻	 ◭ 🔻   ◭ 🔻 	◭ 🔻   ◭ 🔻 ◭ 🔻  ◭ 🔻	//triangle part!

            Triangle triangle1 = new Triangle(5, 10);
            Triangle triangle3 = new Triangle();

            double triangleA = triangle1.getArea();
            Console.WriteLine("arean av din  ▲  är: " + triangleA + " m2");


            double triangleC = triangle3.getVolym();
            Console.WriteLine("volymen av din  ▲  är: " + triangleC + " cm3");


            radius5.PartitionCode();


            //triangle in questions/anwser form, write/read. (userinput)
            Console.WriteLine("En triangel består av 3 sidor:"); //how many cm are the side?
            Console.Write("hur många cm är den första sidan? Skriv in svar: ");
            float triangleX = float.Parse(Console.ReadLine()); // userinput
            Console.Write("hur många cm är den andra sidan? Skriv in svar: ");
            float triangleY = float.Parse(Console.ReadLine()); // userinput
            Console.Write("hur många cm är den tredje sidan? Skriv in svar: ");
            float triangleZ = float.Parse(Console.ReadLine()); // userinput

            Triangle triangle2 = new Triangle(triangleX, triangleY, triangleZ); //objekt with userinput inparameters
            double triangleB = triangle2.getCircumference(); //Call method to get Circumference.
            Console.WriteLine("omkretsen av din ▲ är: " + triangleB + " cm"); //printing Circumference with userinput


            radius5.PartitionCode();
            Console.ReadKey();

            // ◭ 🔻  ◭ 🔻	◭ 🔻   ◭ 🔻	 ◭ 🔻   ◭ 🔻 	◭ 🔻   ◭ 🔻 ◭ 🔻  ◭ 🔻	// end of triangle part
        }
    }
}