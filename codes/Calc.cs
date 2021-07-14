using System;
namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Declare variables and then initialize to zero.
            int num1 = 0; int num2 = 0;

            // Display title as the C# console calculator app.
            System.Console.WriteLine("Console Calculator in C#\r");
            System.Console.WriteLine("------------------------\n");

            // Ask the user to type the first number.
            System.Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToInt32(System.Console.ReadLine());

            // Ask the user to type the second number.
            System.Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToInt32(System.Console.ReadLine());

            // Ask the user to choose an option.
            System.Console.WriteLine("Choose an option from the following list:");
            System.Console.WriteLine("\ta - Add");
            System.Console.WriteLine("\ts - Subtract");
            System.Console.WriteLine("\tm - Multiply");
            System.Console.WriteLine("\td - Divide");
            System.Console.Write("Your option? ");

            // Use a switch statement to do the math.
            switch (System.Console.ReadLine())
            {
                case "a":
                    System.Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    System.Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    System.Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    System.Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            // Wait for the user to respond before closing.
            System.Console.Write("Press any key to close the Calculator console app...");
            System.Console.ReadKey();
        }
    }
}
