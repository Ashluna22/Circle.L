using System;

class Program
{
    static void Main()
    {
        Circle circle = null;
        bool validInput = false;

        while (!validInput)
        {
            Console.Write("Enter the radius of the circle: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double radius) && radius > 0)
            {
                circle = new Circle(radius);
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }

        bool continueLoop = true;

        while (continueLoop)
        {
            Console.WriteLine($"Diameter: {circle.CalculateDiameter()}");
            Console.WriteLine($"Circumference: {circle.CalculateCircumference()}");
            Console.WriteLine($"Area: {circle.CalculateArea()}");

            Console.Write("Should the circle grow? (yes/no): ");
            string response = Console.ReadLine().ToLower();

            if (response == "yes")
            {
                circle.Grow();
            }
            else if (response == "no")
            {
                continueLoop = false;
                Console.WriteLine($"Goodbye! The final radius of the circle is {circle.GetRadius()}.");
            }
            else
            {
                Console.WriteLine("Invalid response. Please enter 'yes' or 'no'.");
            }
        }
    }
}
