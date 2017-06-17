namespace Phone
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ').ToArray();
            string[] names = Console.ReadLine().Split(' ').ToArray();
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string[] cleanNumbers = new string[numbers.Length];

            while (input[0] != "done")
            {
                if (input[0] == "call")
                {
                    MakingCalls(input, numbers, names, cleanNumbers);
                }
                else if (input[0] == "message")
                {
                    SendingMessages(input, numbers, names, cleanNumbers);
                }
                input = Console.ReadLine().Split(' ').ToArray();
            }

        }
        public static void MakingCalls(string[] input, string[] numbers, string[] names, string[] cleanNumbers)
        {
            long number = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (input[1] == names[i])
                {
                    Console.WriteLine($"calling {numbers[i]}...");
                    ParsingOnlyDigits(numbers, cleanNumbers);
                    number = long.Parse(cleanNumbers[i]);
                }
                else if (input[1] == numbers[i])
                {
                    Console.WriteLine($"calling {names[i]}...");
                    ParsingOnlyDigits(numbers, cleanNumbers);
                    number = long.Parse(cleanNumbers[i]);
                }


            }
            long sumOfDigits = CalculatingSumOfDigits(number);
            var duration = CalculatingDuration(sumOfDigits);
            if (sumOfDigits % 2 == 0)
            {
                Console.WriteLine($"call ended. duration: {duration}");
            }
            else
            {
                Console.WriteLine("no answer");
            }
        }
        public static void SendingMessages(string[] input, string[] numbers, string[] names, string[] cleanNumbers)
        {
            string number = string.Empty;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (input[1] == names[i])
                {
                    Console.WriteLine($"sending sms to {numbers[i]}...");
                    ParsingOnlyDigits(numbers, cleanNumbers);
                    number = cleanNumbers[i];
                }
                else if (input[1] == numbers[i])
                {
                    Console.WriteLine($"sending sms to {names[i]}...");
                    ParsingOnlyDigits(numbers, cleanNumbers);
                    number = cleanNumbers[i];
                }
            }
            long differenceOfDigits = DifferenceOfDigits(number);
            if (differenceOfDigits % 2 == 0)
            {
                Console.WriteLine("meet me there");
            }
            else
            {
                Console.WriteLine("busy");
            }
        }
        public static long CalculatingSumOfDigits(long number)
        {
            long sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        public static long DifferenceOfDigits(string number)
        {
            char[] digits = number.ToCharArray();
            long difference = (long)char.GetNumericValue(digits[0]);
            for (int i = 1; i < digits.Length; i++)
            {
                char.GetNumericValue(digits[i]);
                difference -= digits[i];
            }
            difference = Math.Abs(difference);
            return difference;
        }
        public static string CalculatingDuration(long sumOfDigits)
        {
            TimeSpan timespan = TimeSpan.FromSeconds(sumOfDigits);
            string duration = timespan.ToString(@"mm\:ss");
            return duration;
        }
        public static void ParsingOnlyDigits(string[] numbers, string[] newNumbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                newNumbers[i] = new String(numbers[i].Where(Char.IsDigit).ToArray());
            }
        }
    }
}
