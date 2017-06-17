namespace _05.BPM_Counter
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int BPM = int.Parse(Console.ReadLine());
            int beats = int.Parse(Console.ReadLine());
            Console.Write($"{Math.Round(beats / 4.0, 1) } bars - ");
            double seconds = beats * 60.0 / BPM;
            int minutes = (int)seconds / 60;
            seconds -= minutes * 60;
            Console.WriteLine($"{minutes}m {Math.Floor(seconds)}s");
        }
    }
}
