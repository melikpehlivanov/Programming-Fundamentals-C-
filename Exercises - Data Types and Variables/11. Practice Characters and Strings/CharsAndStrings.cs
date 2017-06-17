namespace _11.Practice_Characters_and_Strings
{
    using System;

    public class CharsAndStrings
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            var hexaD = Convert.ToInt32(name, 16);
            Console.WriteLine(hexaD);
        }
    }
}
