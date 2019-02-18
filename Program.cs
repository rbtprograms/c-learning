using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name.");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);
            Console.WriteLine("How many hours of sleep did you get last night?");
            int hours = int.Parse(Console.ReadLine());
            if(hours < 7)
            {
                Console.WriteLine("Sleep more.");
            }
            else
            {
                Console.WriteLine("Seems adequate.");
            }
        }
    }
}
