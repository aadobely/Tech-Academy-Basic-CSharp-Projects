using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // display welcom message to user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // get the weight from user input
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            // check if package is to heavy ...
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; 
            }

            // ask user for width
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            //get height from user ..
            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            // get lenght 
            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            // check if dimensions are too big... add them together
            int totalDimensions = width + height + length;
            if (totalDimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // end the program
            }

            // calculate the quote by multipling everything then divide by 100 ...
            decimal quote = (width * height * length * weight) / 100m;

            // show the quote to user as dollar ammount
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));
            Console.WriteLine("Thank you!");

            // keep console window open so user can see result ....
            Console.ReadLine();
        }
    }
}