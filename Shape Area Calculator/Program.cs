using System;
using System.Buffers.Text;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace Shape_Area_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Shape Area Calculator

            //              Create a console application that acts as a Shape Area Calculator.
            //              This console application must keep running until the user decides to exit on their own.
            //              Classes that must be included in the project:
            //                  Interface Shape with method for calculating area.
            //                  Circle class that implements the abstract Shape class.
            //                  Should override calculate area method to properly calculate area for a circle.
            //                  Rectangle class that implements the abstract Shape class.
            //                      Should override calculate area method to properly calculate area for a rectangle.
            //                  Square class that implements the abstract Shape class.
            //                      Should override calculate area method to properly calculate area for a square.
            //              The user should be prompted with the shapes below that they can pick:
            //                  1. Circle
            //                  2. Rectangle
            //                  3. Square
            //              Once the user selects the shape, based on the shape, they will be offered prompts that will be:
            //                  Circle
            //                      Radius
            //                  Rectangle
            //                      Length
            //                      Width
            //                  Square
            //                      Length
            //              The result will be written to the command line (Console write line).
            //              A user can select another shape or can exit after the results are posted.
            //              Implement input validation and error handling.
            //                  The calculator can only take in positive numbers and if it’s not a number have it catch the error and print to the screen that they must enter numbers only.
            //                  Make sure the error message pertains to that situation.


            bool running = true;


            while (running)
            {

                int parsedInt = 0;
                string userInput;
                bool validInput = false;

                IShape ChoseShape = null;

                double length = 0;
                double width = 0;
                double radius = 0;



                Console.WriteLine("Area Calculator" +
                               "\nPlease select a shape to calculate" +
                               "\n 1. Circle" +
                               "\n 2. Rectangle" +
                               "\n 3. Square");

                while (!validInput)
                {
                    userInput = Console.ReadLine();
                    try
                    {
                        parsedInt = int.Parse(userInput);
                        if (parsedInt > 0 && parsedInt <= 3)
                        {
                            validInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid response. Respond with 1, 2, or 3.");
                            Console.WriteLine("Please select a shape to calculate" +
                                "\n 1. Circle" +
                                "\n 2. Rectangle" +
                                "\n 3. Square");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid response. Respond with 1, 2, or 3.");
                        Console.WriteLine("Please select a shape to calculate" +
                            "\n 1. Circle" +
                            "\n 2. Rectangle" +
                            "\n 3. Square");
                    }
                }
                validInput = false;


                if (parsedInt == 1)
                {
                    Console.WriteLine("Please enter the radius of your circle. Please use positive numbers.");
                    while (!validInput)
                    {
                        userInput = Console.ReadLine();
                        try
                        {
                            radius = double.Parse(userInput);
                            validInput = true;
                        }
                        catch
                        {
                            Console.WriteLine("Invalid response. Respond with a positive number.");
                        }
                    }
                    ChoseShape = new Circle(radius);
                }
                else if (parsedInt == 2)
                {
                    Console.WriteLine("Please enter the length of your rectangle. Please use positive numbers.");

                    while (!validInput)
                    {
                        userInput = Console.ReadLine();
                        try
                        {
                            length = double.Parse(userInput);
                            validInput = true;
                        }
                        catch
                        {
                            Console.WriteLine("Invalid response. Respond with a positive number.");
                        }
                    }
                    validInput = false;
                    Console.WriteLine("Please enter the width of your rectangle. Please use positive numbers.");

                    while (!validInput)
                    {
                        userInput = Console.ReadLine();
                        try
                        {
                            width = double.Parse(userInput);
                            validInput = true;
                        }
                        catch
                        {
                            Console.WriteLine("Invalid response. Respond with a positive number.");
                        }
                    }
                    ChoseShape = new Rectangle(length, width);

                }
                else if (parsedInt == 3)
                {
                    Console.WriteLine("Please enter the length of a side of your square. Please use positive numbers.");
                    while (!validInput)
                    {
                        userInput = Console.ReadLine();
                        try
                        {
                            length = double.Parse(userInput);
                            validInput = true;
                        }
                        catch
                        {
                            Console.WriteLine("Invalid response. Respond with a positive number.");
                        }
                    }
                    ChoseShape = new Square(length);
                }
                validInput = false;


                ChoseShape.CalculateArea();
                Console.WriteLine($"The area of your shape is {ChoseShape.Area}");
                Console.WriteLine("Would you like to calculate another shape? Respond with 1 or 2." +
                    "\n1. Yes" +
                    "\n2. No");

                while (!validInput)
                {
                    userInput = Console.ReadLine();
                    try
                    {
                        parsedInt = int.Parse(userInput);

                        if (parsedInt == 1)
                        {
                            validInput = true;
                            Console.Clear(); 
                        }
                        else if (parsedInt == 2)
                        {
                            running = false;
                            validInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid response, try again.");
                            Console.WriteLine("Would you like to calculate another shape?" +
                            "\n1. Yes" +
                            "\n2. No");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid response, try again.");
                        Console.WriteLine("Would you like to calculate another shape?" +
                        "\n1. Yes" +
                        "\n2. No");
                    }
                    
                }

            }
            Console.WriteLine("Hit any key to close.");
            
            Console.ReadKey();

        }
    }
}
