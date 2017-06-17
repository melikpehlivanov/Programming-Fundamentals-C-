namespace _6.Notifications
{
    using System;
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());


            for (int i = 0; i < number; i++)
            {
                string text = Console.ReadLine();//err

                if (text == "success")//&& te == err
                {
                    string text2 = Console.ReadLine();
                    var text3 = (Console.ReadLine());

                    ShowSuccess(text2, text3);

                }
                else if (text == "error")
                {

                    string text22 = Console.ReadLine();
                    int text33 = int.Parse(Console.ReadLine());
                    ShowErr(text22, text33);
                }

            }
        }

        static string ShowSuccess(string operation, string message)
        {
            var SSDD = string.Empty;
            Console.WriteLine($"Successfully executed {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: {message}.");

            return SSDD;

        }
        static string ShowErr(string operation, int code)
        {
            var someShe = string.Empty;

            Console.WriteLine($"Error: Failed to execute {operation}.");
            Console.WriteLine("==============================");
            if (code < 0)
            {
                Console.WriteLine($"Error Code: {code}.");
                Console.WriteLine("Reason: Internal System Failure.");
            }
            else
            {
                Console.WriteLine($"Error Code: {code}.");
                Console.WriteLine("Reason: Invalid Client Data.");
            }
            return someShe;
        }
    }
    }

