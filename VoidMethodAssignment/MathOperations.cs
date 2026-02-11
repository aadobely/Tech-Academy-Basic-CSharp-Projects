using System;

namespace VoidMethodAssignment
{
    // this is the class for doing some math stuff
    class MathOperations
    {
        
        // method takes 2 numbers... does something with first one and shows the second
        public void Calculate(int num1, int num2)
        {
            // multiply first number by 3
            int result = num1 * 3;
            
            Console.WriteLine("First number multiplied by 3: " + result);
            
            
            // just display the second number
            Console.WriteLine("The second number is: " + num2);
        }
        
    }
}