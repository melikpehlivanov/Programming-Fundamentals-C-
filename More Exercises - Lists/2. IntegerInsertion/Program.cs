namespace _2.IntegerInsertion
{
    using System;
    using System.Linq;
   public class InsertingInteger
    {
       public static void Main()
        {
            var input = Console.ReadLine();
            var list = input.Split(' ').Select(int.Parse).ToList();
            input = Console.ReadLine();
 
            while (input != "end")
            {
 
                var currentNum = int.Parse(input);
                var firstDigit = input[0].ToString();
                var index = int.Parse(firstDigit);
 
                list.Insert(index, currentNum);
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
