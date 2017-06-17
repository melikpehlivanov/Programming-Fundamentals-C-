namespace _08.SMS_Typing
{
    using System;

    public class SMS_Typing
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var SMS = string.Empty;

            SMS = GetSMS(n, SMS);

            Console.WriteLine(SMS);
        }

        private static string GetSMS(int n, string SMS)
        {
            for (int i = 0; i < n; i++)
            {
                var currentMessageCharacters = Console.ReadLine();

                if (currentMessageCharacters == "0")
                {
                    SMS += " ";
                }

                else
                {
                    var mainDigit = int.Parse(currentMessageCharacters[0].ToString());
                    var numberOfDigits = currentMessageCharacters.Length;

                    var offset = (mainDigit - 2) * 3;

                    if (mainDigit == 8 || mainDigit == 9)
                    {
                        offset++;
                    }

                    var letterIndex = offset + numberOfDigits - 1;

                    var currentMessage = (char)(letterIndex + 97);

                    SMS += currentMessage;
                }
            }

            return SMS;
        }
    }
}


