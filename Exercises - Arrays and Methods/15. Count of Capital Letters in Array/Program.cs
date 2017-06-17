namespace _15.Count_of_Capital_Letters_in_Array
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            int counter = 0;

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                if (currentWord.Length == 1)
                {
                    char character = currentWord[0];
                    if (character >= 'A' && character <= 'Z')
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
        }
    }

