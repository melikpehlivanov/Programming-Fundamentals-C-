namespace _03.HornetAssault
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var beehives = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            var hornets = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();

            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count<=0)
                {
                    break;
                }
                if (hornets.Sum()>beehives[i])
                {
                    beehives.RemoveAt(i);
                    i--;
                }
                else
                {
                    beehives[i] -= hornets.Sum();
                    hornets.RemoveAt(0);
                }
            }
            if (beehives.Where(h=>h>0).ToList().Count>0)
            {
                Console.WriteLine(string.Join(" ", beehives.Where(h=> h>0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
