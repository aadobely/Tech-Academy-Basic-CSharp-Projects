using System;


namespace VoidMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // make new instance of the class
            MathOperations math = new MathOperations();
            
            
            // calling method first time with regular way
            Console.WriteLine("--- First call ---");
            math.Calculate(10, 25);
            
            Console.WriteLine();
            
            // calling method second time but with named paramters
            Console.WriteLine("--- Second call with names ---");
            math.Calculate(num1: 15, num2: 40);
            
            
            // keep window open so i can see results
            Console.ReadLine();
        }
    }
}