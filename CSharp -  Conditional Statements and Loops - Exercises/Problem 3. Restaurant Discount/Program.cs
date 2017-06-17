using System;
namespace Problem_3.Restaurant_Discount
{
    class Program
    {
        static void Main()
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();


            if (groupSize > 1 && groupSize <= 50)
            {
                if (package == "Normal")
                {
                    var total = 2500 + 500;
                    var totalPrice = total - (total * 5) / 100.0;
                    var pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
                else if (package == "Gold")
                {
                    var total = 2500 + 750;
                    var totalPrice = total - (total * 10) / 100.0;
                    var pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }

                else if (package == "Platinum")
                { 
                    var total = 2500 + 1000;
                    var totalPrice = total - (total * 15) / 100.0;
                    var pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
            }

            else if  (groupSize > 50 && groupSize <= 100)
            {
                if (package == "Normal")
                {
                    var total = 5000 + 500;
                    var totalPrice = total - (total * 5) / 100.0;
                    var pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
                else if (package == "Gold")
                {
                    var total = 5000 + 750;
                    var totalPrice = total - (total * 10) / 100.0;
                    var pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }

                else if (package == "Platinum")
                {
                    var total = 5000 + 1000;
                    var totalPrice = total - (total * 15) / 100.0;
                    var pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }

                else if (groupSize > 100 &&groupSize <= 120)
                {
                    if (package == "Normal")
                    {
                        var total = 7500 + 500;
                        var totalPrice = total - (total * 5) / 100.0;
                        var pricePerPerson = totalPrice / groupSize;
                        Console.WriteLine("We can offer you the Great Hall");
                        Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                    }
                    else if (package == "Gold")
                    {
                        var total = 7500 + 750;
                        var totalPrice = total - (total * 10) / 100.0;
                        var pricePerPerson = totalPrice / groupSize;
                        Console.WriteLine("We can offer you the Great Hall");
                        Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                    }

                    else if (package == "Platinum")
                    {
                        var total = 7500 + 1000;
                        var totalPrice = total - (total * 15) / 100.0;
                        var pricePerPerson = totalPrice / groupSize;
                        Console.WriteLine("We can offer you the Great Hall");
                        Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                    }

                }

            }
            else if (groupSize>120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
