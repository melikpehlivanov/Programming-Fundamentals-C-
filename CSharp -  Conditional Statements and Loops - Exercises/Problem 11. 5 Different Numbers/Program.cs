using System;

namespace Problem_11._5_Different_Numbers
{
    public class Program
    {

        public static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNUm = int.Parse(Console.ReadLine());

            if (secondNUm - firstNum < 4)
            {
                Console.WriteLine("No");
                return;
            }

            for (int i = firstNum; i <= secondNUm - 4; i++)
            {
                for (int j = i + 1; j <= secondNUm - 3; j++)
                {
                    for (int k = j + 1; k <= secondNUm - 2; k++)
                    {
                        for (int l = k + 1; l <= secondNUm - 1; l++)
                        {
                            for (int m = l + 1; m <= secondNUm; m++)
                            {
                                Console.WriteLine($"{i} {j} {k} {l} {m}");
                            }
                        }
                    }
                }
            }
        }
    }
}
