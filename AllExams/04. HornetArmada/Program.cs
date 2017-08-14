namespace _04.HornetArmada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            //EVERY LEGION HAS ITS ACTIVITY
            //CREATE TWO DICTIONARIES
            //ONE TO STORE THE LEGIONS BY ACTIVITES
            //AND ONE TO STORE THEM BY NAME, WITH A NESTED ONE => SOLDIER TYPES AND THEIR COUNT
            Dictionary<string, int> legionsWithActivity = new Dictionary<string, int>();
            Dictionary<string, Dictionary<string, long>> legionsWithSoldiers =
                new Dictionary<string, Dictionary<string, long>>(); //THERE IS A LONG HERE

            //READ N
            int n = int.Parse(Console.ReadLine());

            //A SIMPLE REGEX PATTERN WITH GROUPS TO EXTRACT THE INPUT
            //I'M LAZY TO SPLIT
            string inputPattern = @"(\d+)\s\=\s(.+)\s\-\>\s(.+)\:(\d+)";
            Regex inputRegex = new Regex(inputPattern);

            //THE LOOP THAT GOES FROM 0 TO N TO READ N LINES
            for (int i = 0; i < n; i++)
            {
                //READ THE INPUT LINE AND CREATE A MATCH WITH THE REGEX ON IT
                //BY DEFINITION THERE ARE NO INVALID LINES
                //SO NO NEED TO CHECK IT
                Match inputMatch = inputRegex.Match(Console.ReadLine());

                //EXTRACT THE DATA
                int lastActivity = int.Parse(inputMatch.Groups[1].Value); //EXTRACT THE LAST ACTIVITY
                string legionName = inputMatch.Groups[2].Value; //EXTRACT THE LEGION NAME
                string soldierType = inputMatch.Groups[3].Value; //EXTRACT THE SOLDIER TYPE
                int soldierCount = int.Parse(inputMatch.Groups[4].Value); //EXTRACT THE SOLDIER COUNT

                //IF THE LEGION DOES NOT EXIST
                if (!legionsWithActivity.ContainsKey(legionName))
                {
                    //ADD IT IN BOTH DICTIONARIES
                    legionsWithActivity.Add(legionName, lastActivity);
                    legionsWithSoldiers.Add(legionName, new Dictionary<string, long>());
                }

                //TAKE FROM THE DICTIONARY WITH ACTIVITIES, THE ONE THAT CORRESPONDS TO THE GIVEN LEGION NAME
                //IF IT IS LOWER THAN THE GIVEN ONE, UPDATE IT WITH THE NEW ONE
                if (lastActivity > legionsWithActivity[legionName])
                {
                    legionsWithActivity[legionName] = lastActivity;
                }

                //IF THE CURRENT LEGION DOES NOT CONTAIN THE GIVEN SOLDIER TYPE
                if (!legionsWithSoldiers[legionName].ContainsKey(soldierType))
                {
                    //ADD THE CURRENT SOLDIER TYPE
                    legionsWithSoldiers[legionName].Add(soldierType, 0);
                }

                //INCREASE THE COUNT OF SOLDIERS
                legionsWithSoldiers[legionName][soldierType] += soldierCount;
            }

            //GET THE QUERY OF THE LAST LINE OF INPUT AFTER WE'VE PROCESSED ALL N INPUT LINES
            //SPLIT IT BY "\"
            //IF IT HAS 2 ELEMENTS THEN IT IS "activity\soldierType"
            //IF IT HAS 1 ELEMENT THEN IT IS "soldierType"
            string[] queryParams = Console.ReadLine().Split('\\');

            //THE CHECK FOR PARAMETER COUNT
            if (queryParams.Length > 1)
            {
                //TAKE THE GIVEN ACTIVITY
                int activity = int.Parse(queryParams[0]);
                //TAKE THE GIVEN SOLDIER TYPE
                string soldierType = queryParams[1];

                //FILTER ALL LEGIONS
                //WHERE (TAKE) EVERY LEGION CONTAINS THE GIVEN SOLDIER TYPE
                //ORDER BY DESCENDING BY THE VALUE OF THE GIVEN SOLDIER TYPE
                foreach (var legionEntry in legionsWithSoldiers
                    .Where(legion => legion.Value.ContainsKey(soldierType))
                    .OrderByDescending(legion => legion.Value[soldierType]))
                {
                    //TAKE THE LEGION'S NAME AND CHECK IN THE DICTIONARY WITH ACTIVITIES
                    //IF ITS VALUE IS LOWER THAN THE GIVEN ACTIVITY, PRINT IT
                    if (legionsWithActivity[legionEntry.Key] < activity)
                    {
                        Console.WriteLine("{0} -> {1}", legionEntry.Key,
                            legionsWithSoldiers[legionEntry.Key][soldierType]);
                    }
                }
            }
            else
            {
                //TAKE THE SOLDIER TYPE
                string soldierType = queryParams[0];

                //THIS TIME FOREACH THE LEGIONS WITH ACTIVITY DICTIONARY
                //AND ORDER THEM DESCENDING BY VALUE (ACTIVITY)
                foreach (var legionEntry in legionsWithActivity.OrderByDescending(legion => legion.Value))
                {
                    //TAKE THE LEGION'S KEY (NAME) AND CHECK IN THE DICTIONARY WITH SOLDIER TYPES
                    //IF IT CONTAINS THE GIVEN SOLDIER TYPE
                    //IF YES, PRINT THE LEGION WITH ITS DATA
                    if (legionsWithSoldiers[legionEntry.Key].ContainsKey(soldierType))
                    {
                        Console.WriteLine("{0} : {1}", legionEntry.Value, legionEntry.Key);
                    }
                }
            }
        }
    }
} 
