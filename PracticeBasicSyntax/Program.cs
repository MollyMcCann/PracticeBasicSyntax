    using System;

    namespace RectangleApplication
    {
        class Rectangle
        {

            // member variables
            double length;
            double width;

            public void Acceptdetails()
            {
                length = 60;
                width = 75;
            }
            public double GetArea()
            {
                return length * width;
            }
            public void Display()
            {
                Console.WriteLine("Length: {0}", length);
                Console.WriteLine("Width: {0}", width);
                Console.WriteLine("Area: {0}", GetArea());
            }
        }
        class ExecuteRectangle
        {
            static void Main(string[] args)
            {
                Rectangle r = new Rectangle();
                r.Acceptdetails();
                r.Display();
                Console.ReadLine();
                // quick practice on casting

                double d = 5673.74;
                int i;

                // cast double to int.
                i = (int)d;
                Console.WriteLine(i);
                Console.ReadKey();

             }
        }
    }
