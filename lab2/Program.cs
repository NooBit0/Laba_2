using System;
using CircleNameSpace;
using InputPropertyCircle;

namespace Lab2
{
    internal class Program
    {
        private static void Main()
        {
            Circle[] circles = new Circle[3];
            var propertyCircle = EnterProperty();

            circles[0] = new Circle(propertyCircle.Item1, propertyCircle.Item2, propertyCircle.Item3, propertyCircle.Item4);
            Console.WriteLine();
            propertyCircle = EnterProperty();
            circles[1] = new Circle(propertyCircle.Item1, propertyCircle.Item2, propertyCircle.Item3, propertyCircle.Item4);
            circles[2] = new Circle();

            Print(circles);

            circles[2].AxisShift(9);

            Print(circles);

            Console.WriteLine($"\nOne quarter coordinate: {Circle.Check(circles[0], circles[1])}");
        }

        private static void Print(Circle[] circles)
        {
            Header();

            foreach (var circle in circles)
            {
                Console.WriteLine(circle);
            }
        }

        private static void Header()
        {
            Console.WriteLine("\nCentral|\tRadius| Area Circle| \tLength Polygon|");
        }

        private static (int, int, int, double) EnterProperty()
        {
            (int numberParties, int circleCenterX, int circleCenterY, double radiusCirle) property;

            Console.WriteLine("Enter number partiesint");
            property.numberParties = Input.InputProperty(3);

            Console.WriteLine("Enter X");
            property.circleCenterX = Input.InputProperty();

            Console.WriteLine("Enter Y");
            property.circleCenterY = Input.InputProperty();

            Console.WriteLine("Enter radius");
            property.radiusCirle = Input.InputProperty(0);

            return property;
        }
    }
}
