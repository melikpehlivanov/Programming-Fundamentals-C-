namespace _01.Hello_Name
{
    using System;
    public class Program
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {NamePrinter(name)}!");

        }

        private static string NamePrinter(string name)
        {
            return name;

        }
    }
}
