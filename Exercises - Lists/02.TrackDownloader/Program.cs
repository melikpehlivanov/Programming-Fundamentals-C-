namespace _02.TrackDownloader
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var blacklistWords = Console.ReadLine()
                .Split(' ')
                .ToList();
            var files = Console.ReadLine();
            var toDownload = new List<string>();

            while (files != "end")
            {
                bool isBlacklisted = false;
                foreach (var keyword in blacklistWords)
                {
                    if (files.Contains(keyword))
                    {
                        isBlacklisted = true;
                        break;
                    }

                }
                if (!isBlacklisted)
                {
                    toDownload.Add(files);
                }
                files = Console.ReadLine();
            }
            toDownload.Sort();
            foreach (var track in toDownload)
            {
                Console.WriteLine(track);
            }
        }
    }
}

