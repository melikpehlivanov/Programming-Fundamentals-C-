using System;
using System.Collections.Generic;

namespace _05.User_Logins
{
   public class Program
    {
       public static void Main()
        {
            var dictionary=new Dictionary<string, string>();
            var list = Console.ReadLine()
                .Split(new char[] {' ', '-', '>'}, StringSplitOptions.RemoveEmptyEntries);

            while (list[0]!="login")
            {
                var username = list[0];
                var password = list[1];

                if (!dictionary.ContainsKey(username))
                {
                    dictionary[username] = password;
                }
                dictionary[username] = password;

                list = Console.ReadLine()
                    .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            list = Console.ReadLine()
                .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            var unsuccessfulLogins = 0;

            while (list[0]!="end")
            {
                var username = list[0];
                var password = list[1];

                if (dictionary.ContainsKey(username) && dictionary.ContainsValue(password))
                {
                    Console.WriteLine($"{username}: logged in successfully");
                }
                else
                {
                    unsuccessfulLogins++;
                    Console.WriteLine($"{username}: login failed");
                }


                list = Console.ReadLine()
                    .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }
            
                if (unsuccessfulLogins>0)
                {
                    Console.WriteLine($"unsuccessful login attempts: {unsuccessfulLogins}");
                }
            
        }  
    }
}
