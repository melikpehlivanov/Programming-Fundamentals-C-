namespace Array_Symmetry
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            string[] reversed = new string[words.Length];
            bool symmetry = true;

            for (int i = 0; i < words.Length; i++)
            {
                reversed[i] = words[i];
            }
            Array.Reverse(reversed);
            for (int i = 0; i < words.Length; i++)
            {
                if (reversed[i] != words[i])
                {
                    symmetry = false;
                }
            }
            if (symmetry)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
