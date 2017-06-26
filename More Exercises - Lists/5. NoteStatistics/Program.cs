using System.Collections.Generic;

namespace _5.NoteStatistics
{
    using System;
    using System.Linq;
   public class Program
    {
       public static void Main()
       {
           var input = Console.ReadLine()
               .Split(' ')
               .Select(double.Parse)
               .ToList();
            var noteFrequencies=new Dictionary<string, double>
            {
                { "C", 261.63},{ "C#", 277.18}, { "D", 293.66},
                { "D#", 311.13}, { "E",329.63},
                { "F", 349.23}, { "F#", 369.99}, { "G", 392.00},
                { "G#",415.30},{ "A",440.00}, { "A#",466.16},{ "B", 493.88}
            };

            var listedNotes=new List<string>();
        

            #region gettingTheNamesOfTheListedFrequencies

           foreach (var noteFreqs in input)
           {
               foreach (var freq in noteFrequencies)
               {
                   var notes = freq.Key;
                   var frequenceNumbers = freq.Value;

                   if (noteFreqs == frequenceNumbers)
                   {
                       listedNotes.Add(notes);
                   }
               }
           }
           Console.WriteLine($"Notes: {string.Join(" ", listedNotes)}");

            #endregion

            //Here we will get the sharpers and the naturals
            var sharps=new List<string>();
            var naturals=new List<string>();

            #region Naturals and Sharpers

           foreach (var NaturalAndSharpers in listedNotes)
           {
               if (NaturalAndSharpers.Contains('#'))
               {
                   sharps.Add(NaturalAndSharpers);
               }
               else
               {
                   naturals.Add(NaturalAndSharpers);
               }
           }
           Console.WriteLine($"Naturals: {string.Join(", ", naturals)}");
           Console.WriteLine($"Sharps: {string.Join(", ", sharps)}");

            #endregion

           double sum = 0.0;

            foreach (var firstSum in naturals)
           {
               foreach (var secondSum in noteFrequencies)
               {
                   var nameOfNote = secondSum.Key;
                   var frequenciesNumbers = secondSum.Value;
                   if (firstSum==nameOfNote)
                   {
                       sum += frequenciesNumbers;
                   }
               }
           }
           Console.WriteLine($"Naturals sum: {sum}");

           double sharperSum = 0.0;
           foreach (var firstSum in sharps)
           {
               foreach (var secondSum in noteFrequencies)
               {
                   var nameOfNote = secondSum.Key;
                   var frequenciesNumbers = secondSum.Value;
                   if (firstSum == nameOfNote)
                   {
                       sharperSum += frequenciesNumbers;
                   }
               }
           }
           Console.WriteLine($"Sharps sum: {sharperSum}");
        }
    }
}
