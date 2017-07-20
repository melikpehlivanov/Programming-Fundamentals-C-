using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.Lambada_Expressions
{
   public class Program
    {
       public static void Main()
        {
            var dataBaseDictionary =
                new Dictionary<string, Dictionary<string, string>>();

            string input = Console.ReadLine();
            while (input != "lambada")
            {
                string[] inputTokens = input
                    .Split(new string[] { " => ", "." },
                        StringSplitOptions.RemoveEmptyEntries);

                if (inputTokens[0] == "dance")
                {
                    var selectors = dataBaseDictionary.Keys.ToList();

                    foreach (var selector in selectors)
                    {
                        var selectorObjects = dataBaseDictionary[selector].Keys.ToList();
                        foreach (var selectorObject in selectorObjects)
                        {
                            dataBaseDictionary[selector][selectorObject] =
                                selectorObject + "." + dataBaseDictionary[selector][selectorObject];
                        }
                    }
                }
                else
                {
                    string selector = inputTokens[0];
                    string selectorObject = inputTokens[1];
                    string selectorPropertiesToken = inputTokens[2];

                    if (!dataBaseDictionary.ContainsKey(selector))
                    {
                        dataBaseDictionary.Add(selector, new Dictionary<string, string>());
                    }

                    dataBaseDictionary[selector][selectorObject] = selectorPropertiesToken;
                }

                input = Console.ReadLine();
            }

            foreach (var selectorData in dataBaseDictionary)
            {
                string selector = selectorData.Key;
                var selectorObjectsData = selectorData.Value;
                foreach (var selectorObjectData in selectorObjectsData)
                {
                    string selectorObject = selectorObjectData.Key;
                    string property = selectorObjectData.Value;

                    Console.WriteLine($"{selector} => {selectorObject}.{property}");
                }
            }
    }
}
}
