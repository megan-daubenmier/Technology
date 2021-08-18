using System;

namespace Technology
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer testComputer = new Computer("Yoga", "Megan", 2021, 512.0, "Windows 10");
            Laptop testLaptop = new Laptop("Yoga", "Megan", 2021, 512.0, "Windows 10", "SSD");
            Console.WriteLine(testComputer.ID);
            Console.WriteLine(testLaptop.ID);
        }
    }
}
