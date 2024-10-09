using System;

namespace ConsoleApp
{
    // Create a class named MyMathClass
    class MyMathClass
    {
        // Create a void method that takes two integers as parameters
        public void DoMathOperation(int num1, int num2)
        {
            // Perform a math operation on the first integer (e.g., multiply by 2)
            int result = num1 * 2;

            // Display the result of the operation and the second integer
            Console.WriteLine($"Result of the math operation on the first integer: {result}");
            Console.WriteLine($"Second integer: {num2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            MyMathClass mathClass = new MyMathClass();

            // Call the method, passing two numbers
            mathClass.DoMathOperation(5, 10);

            // Call the method, specifying the parameters by name
            mathClass.DoMathOperation(num1: 7, num2: 15);
        }
    }
}
