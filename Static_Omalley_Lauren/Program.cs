using System;

namespace Static_Omalley_Lauren
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integers
            Console.WriteLine("Integers Methods");  // Header for the integers
            Console.WriteLine("15 + 88 is " + Calculate.Add(15, 88)); // Prints the equation with the answer to the console
            Console.WriteLine("78 - 88 is " + Calculate.Sub(78, 88)); // Prints the equation with the answer to the console
            Console.WriteLine("8 * 9 is " + Calculate.Mult(8, 9)); // Prints the equation with the answer to the console
            Console.WriteLine("77 / 8 is " + Calculate.Div(77, 8)); // Prints the equation with the answer to the console

            // Floats
            Console.WriteLine("\nFloat Methods");  // Header for the floats
            Console.WriteLine("15.55f + 88.65f is " + Calculate.Add(15.55f, 88.65f)); // Prints the equation with the answer to the console
            Console.WriteLine("78.45f + 88.89f is " + Calculate.Sub(78.45f, 88.89f)); // Prints the equation with the answer to the console
            Console.WriteLine("8.99f + 9.65f is " + Calculate.Mult(8.99f, 9.65f)); // Prints the equation with the answer to the console
            Console.WriteLine("77.265f + 8.0f is " + Calculate.Div(77.265f, 8.0f)); // Prints the equation with the answer to the console
        }
    }
}
