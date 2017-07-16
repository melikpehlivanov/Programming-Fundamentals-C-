using System;
using System.Collections.Generic;

namespace _06.Filter_Base
{
   public class Program
    {
       public static void Main()
        {
            var ageDictionary=new Dictionary<string, int>();
            var salaryDictionary = new Dictionary<string, double>();
            var positionDictionary = new Dictionary<string, string>();
            var list = Console.ReadLine()
                .Split(new char[] {' ', '-', '>'}, StringSplitOptions.RemoveEmptyEntries);

            while (list[0]!="filter")
            {
                var name = list[0];
                var age = list[1];

                int result;
                double floatingResult;
                if (int.TryParse(age, out result))
                {
                    ageDictionary[name] = result;
                }
                else if (double.TryParse(age, out floatingResult))
                {
                    salaryDictionary[name] = floatingResult;
                }
                else
                {
                    positionDictionary[name] = age;
                }





                list = Console.ReadLine()
                    .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }
            var caseWhichIShouldPrint = Console.ReadLine();

            if (caseWhichIShouldPrint=="Position")
            {
                foreach (var items in positionDictionary)
                {
                    Console.WriteLine($"Name: {items.Key}");
                    Console.WriteLine($"Position: {items.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
           else if (caseWhichIShouldPrint == "Salary")
            {
                foreach (var items in salaryDictionary)
                {
                    Console.WriteLine($"Name: {items.Key}");
                    Console.WriteLine($"Salary: {items.Value:f2}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else
            {
                  foreach (var items in ageDictionary)
                    {
                        Console.WriteLine($"Name: {items.Key}");
                        Console.WriteLine($"Age: {items.Value}");
                        Console.WriteLine(new string('=',20));
                    }
                }


        }
    }
}
