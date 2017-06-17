namespace _15.Calculator
{
    using System;
   public class Calculator
    {
       public static void Main()
       {
           int n = int.Parse(Console.ReadLine());
            char a = char.Parse(Console.ReadLine());
           int number = int.Parse(Console.ReadLine());

           if (a=='+')
           {
               int equals = n + number;
               Console.WriteLine($"{n} + {number} = {equals}");
           }
          else if (a == '*')
           {
             int  equals = n * number;
               Console.WriteLine($"{n} * {number} = {equals}");
           }
         else  if (a == '/')
           {
              int equals = n / number;
               Console.WriteLine($"{n} / {number} = {equals}");
           }
          else if (a == '-')
           {
             int  equals = n - number;
               Console.WriteLine($"{n} - {number} = {equals}");
           }

        }
    }
}
