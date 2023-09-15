using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "Josh";
            string myLocation = "Utah";

            // Output name and location using string interpolation
            Console.WriteLine($"My name is {myName}, I am from {myLocation}");

            // Get current time using DateTime.Now, then format and output date.
            DateTime currentDate = DateTime.Now;
            Console.WriteLine($"Today's date is: {currentDate.ToShortDateString()}");

            // Calculate the number of days until Christmas this year and output the result.
            int daysTillChristmas = (new DateTime(2023, 12, 25) - currentDate).Days;
            Console.WriteLine($"There are {daysTillChristmas} days until Christmas");

            // Pause program and wait for keypress before continuing
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);

            // Program from 2.1 of the Yellow Book
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.Write("\nInput the desired window width in meters: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.Write("Input the desired window height in meters: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            // Pause program and wait for keypress before exiting
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
