using System;

namespace Problem_4.Beverage_Labels
{
    class BeverageLabels
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            double ml = double.Parse(Console.ReadLine());
            double kcal = double.Parse(Console.ReadLine());
            double grams = double.Parse(Console.ReadLine());
            var kcalPerOneHunderMl = (kcal * ml) / 100;
            var sugarsPerOneHunderdMl = (grams * ml) / 100.0;
            Console.WriteLine(ml+"ml" + ' '+ name + ':');
            Console.WriteLine(kcalPerOneHunderMl + "kcal," + ' ' + sugarsPerOneHunderdMl + "g" + ' ' + "sugars");
        }
    }
}
