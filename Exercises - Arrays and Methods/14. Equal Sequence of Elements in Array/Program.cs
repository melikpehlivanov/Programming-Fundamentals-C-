using System.Collections.Generic;
using System.Linq;

namespace _14.Equal_Sequence_of_Elements_in_Array
{
    using System;
   public class Program
    {
        public static void Main()
        {
            var stringArray = Console.ReadLine().Split(' ').ToList();
            bool areEqual = stringArray.Any()
                ? stringArray.All(str => str.Equals(stringArray[0], StringComparison.InvariantCultureIgnoreCase))
                : true;

            if (areEqual)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
