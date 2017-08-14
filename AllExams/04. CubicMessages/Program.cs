namespace _04.CubicMessages
{
    using System;
    using System.Text.RegularExpressions;
    using System.Linq;
    using System.Text;
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Over!")
                {
                    break;
                }
                var count = int.Parse(Console.ReadLine());

                var regex = new Regex($@"(^\d+)([A-Za-z]{{{count}}})([^A-Za-z]*$)");
                var match = regex.Match(input);

                if (match.Success)
                {
                    var left = match.Groups[1].Value;
                    var message = match.Groups[2].Value;
                    var right = match.Groups[3].Value;

                    var indexes = string.Concat(left, right)
                        .Where(s => char.IsDigit(s))
                        .Select(s => s - '0'); // парсваме към истински числа

                    var result = new StringBuilder();
                    foreach (var index in indexes)
                    {
                        if (index < 0 || index >= message.Length)
                        {
                            result.Append(' ');
                        }
                        else
                        {
                            result.Append(message[index]);
                        }
                    }
                    Console.WriteLine($"{message} == {result}");
                }
            }
        }
    }
}
