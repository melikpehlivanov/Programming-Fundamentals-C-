namespace _03.PhoenixGrid
{
    using System;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static bool PalindromeBool(string value)
        {
            int i = 0;
            int k = value.Length - 1;
            while (true)
            {
                if (i > k)
                {
                    return true;
                }
                char a = value[i];
                char b = value[k];
                if (a != b)
                {
                    return false;
                }
                i++;
                k--;
            }
        }
        public static void Main()
        {
            var regex = new Regex(@"^([^_\s]{3}\.)*[^_\s]{3}$");
            while (true)
            {
                var text = Console.ReadLine();
                var match = regex.Match(text);
                if (text == "ReadMe")
                {
                    break;
                }

                if (match.Success && PalindromeBool(text))
                {
                    Console.WriteLine("YES");

                }
                
                else
                {
                    Console.WriteLine("NO");

                }

            }
        }
    }
}

