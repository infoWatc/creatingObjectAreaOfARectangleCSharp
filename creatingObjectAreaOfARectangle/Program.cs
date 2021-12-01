/* **************************************************
 * Example of creating an object and doing some work
 ***************************************************/
using System;

namespace creatingObjectAreaOfARectangle
{
    class Rectangle
    {
        //Declare class integer for work
        public int length, breadth;

        //Class Method Rectangle
        public Rectangle(int l, int b)
        {
            length = l;
            breadth = b;            
        }

        //Class Method to process work
        public int Area()
        {
            // integer variable length * breadth;
            return length * breadth;
        }
    }
    // Class Program for Main
    class Program
    {
        static void Main(string[] args)
        {
            // Console Write
            Console.Write("Step 1; Please enter Length of the rectangle: ");

            // Console Read Line convert to integer
            int readLine1 = int.Parse(Console.ReadLine());

            Console.Write("Step 2; Please enter the breadth of the rectangle: ");

            // Console Read Line convert to integer
            int readLine2 = int.Parse(Console.ReadLine());

            // create object with the variables values to do work
            Rectangle rect1 = new Rectangle(readLine1, readLine2);

            // Declare int area to hold data from class method Rectangle.Area
            int area = rect1.Area();

            // Print Line text + variable area
            Console.WriteLine($"The area of the" +
                " Rectangle is {area}");
        }
    }
}
