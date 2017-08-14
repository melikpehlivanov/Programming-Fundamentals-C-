namespace _02.SpyGram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, List<string>> pendingMessages = new Dictionary<string, List<string>>();
            string messagePattern = @"^TO: ([A-Z]+); MESSAGE: (.+);$";


            string privateKey = Console.ReadLine();
            string inputMessage = Console.ReadLine();

            while (inputMessage != "END")
            {
                var validMessage = Regex.Match(inputMessage, messagePattern);
                string matchMessage = validMessage.Value;
                string name = validMessage.Groups[1].ToString();
                string encrypted = string.Empty;
                int key = 0;

                for (int i = 0; i < matchMessage.Length; i++)
                {
                    if (key >= privateKey.Length)
                    {
                        key = 0;
                    }
                    encrypted += (char)(matchMessage[i] + ((int)privateKey[key] - 48));

                    key++;
                }

                if (name != "" || encrypted != "")
                {
                    if (!pendingMessages.ContainsKey(name))
                    {
                        pendingMessages.Add(name, new List<string>());
                    }

                    pendingMessages[name].Add(encrypted);
                }


                inputMessage = Console.ReadLine();
            }

            foreach (var senderMessages in pendingMessages.OrderBy(m => m.Key))
            {
                foreach (var message in senderMessages.Value)
                {
                    Console.WriteLine(message);
                }
            }
        }
    }
}
