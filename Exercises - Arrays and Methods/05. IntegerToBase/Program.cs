using System.CodeDom;
using System.Linq;

namespace _05.IntegerToBase
{
    using System.Collections.Generic;
    using System;
    public class Program
    {
            public static void Main()
            {
                int number = int.Parse(Console.ReadLine());
                int toBase = int.Parse(Console.ReadLine());

                string result = ConvertToBase(number, toBase);

                Console.WriteLine(result);
            }

            public static string ConvertToBase(int number, int toBase)
            {
                string remainder = string.Empty;
                string result = string.Empty;

                while (number > 0)
                {
                    remainder = (number % toBase).ToString();
                    result = result.Insert(0, remainder);
                    number /= toBase;
                }

                return result;
            }
        }
}
