using System;
namespace Problem_1.Debit_Card_Number
{
    class DebitCardNumber
    {
        public static void Main()
        {
            int firstInteger = int.Parse(Console.ReadLine());
            int secondInteger = int.Parse(Console.ReadLine());
            int thirdInteger = int.Parse(Console.ReadLine());
            int forthInteger = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstInteger:D4}" + ' ' + $"{secondInteger:D4}" + ' ' + $"{thirdInteger:D4}" + ' ' + $"{forthInteger:D4}");
            
        }
    }
}
