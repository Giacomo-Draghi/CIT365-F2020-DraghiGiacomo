using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("What is your name?");
            //Storing input from console
            var name = Console.ReadLine();
            Console.WriteLine("\nWhat is your Location? (State or Country)");
            //Storing input from console
            var location = Console.ReadLine();
            //Output of two previus variable Name and Location
            Console.WriteLine($"\nMy name is {name}, I am from {location}");
            //Getting day fromat dd/MM/yyyy (Europe day format)
            var date = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine($"Current Day: {date}");
            //Getting current day
            int dayOfYear = DateTime.Now.DayOfYear;
            //Subtracting current day to the days left to Christmas. 
            int dayToChristmas = 360 - dayOfYear;
            Console.WriteLine($"Days to Christmas: {dayToChristmas}");

            //Program from textbook
            //declaring variables
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            //storing user imnput and making it double
            Console.WriteLine("\nWhat is the width of the window?");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("\nWhat is the height of the window?");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            //Getting wanted information 
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            //outputting processed data
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");
        }
    }
}
