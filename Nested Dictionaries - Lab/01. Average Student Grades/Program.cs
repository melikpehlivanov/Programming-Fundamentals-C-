using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Average_Student_Grades
{
    public class Program
    {
        public static void Main()
        {
            var dictionary= new Dictionary<string, List<double>>();
            var inputNumber = int.Parse(Console.ReadLine());

            for (int countIndex = 0; countIndex < inputNumber; countIndex++)
            {
                string[] inputTokens = Console.ReadLine()
                    .Split(' ');
                var name = inputTokens[0];
                var grade = double.Parse(inputTokens[1]);

                if (!dictionary.ContainsKey(name))
                {
                    dictionary.Add(name, new List<double>());
                }
                dictionary[name].Add(grade);
            }
            foreach (var items in dictionary)
            {
                var name = items.Key;
                var grades = items.Value;
                var average = grades.Average();
            /*Printing it with LinQ
                Console.WriteLine("{0} -> {1} (avg: {2}",
                name,
                string.Join(" ", grades.Select(g=>string.Format("{0:f2}", g.ToString()))));*/

                Console.Write($"{name} -> ");
                foreach (var grade in grades)
                {
                    Console.Write("{0:f2} ", grade);
                }
                Console.WriteLine($"(avg: {average:f2})");
            }
        }
    }
}
