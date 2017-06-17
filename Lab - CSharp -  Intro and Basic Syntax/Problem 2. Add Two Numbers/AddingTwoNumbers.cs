using System;

namespace Problem_2.Add_Two_Numbers
{
    class AddingTwoNumbers
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int sum = firstNumber + secondNumber;
            Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}");
        }
    }
}
