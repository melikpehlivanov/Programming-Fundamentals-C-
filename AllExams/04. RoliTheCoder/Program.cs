namespace _04.RoliTheCoder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Event
    {
        public string Name { get; set; }

        public long Id { get; set; }

        public List<string> Participants { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            Dictionary<long, Event> eventsById = new Dictionary<long, Event>();

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "Time for Code")
                {
                    break;
                }

                string[] tokens = inputLine.Split(new[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                long id = 0;

                if (!long.TryParse(tokens[0], out id))
                {
                    continue;
                }

                id = long.Parse(tokens[0]);

                string eventName = null;
                if (tokens.Length > 1 && tokens[1].StartsWith("#"))
                {
                    eventName = tokens[1].TrimStart('#');
                }
                else
                {
                    continue;
                }

                var participantsToAdd = new List<string>();
                if (tokens.Length > 2)
                {
                    participantsToAdd = tokens.Skip(2).ToList();

                    if (!participantsToAdd.All(p => p.StartsWith("@")))
                    {
                        continue;
                    }
                }

                Event newEvent = new Event
                {
                    Name = eventName,
                    Id = id,
                    Participants = new List<string>()
                };

                if (!eventsById.ContainsKey(id))
                {
                    eventsById[id] = newEvent;
                }

                if (eventsById.ContainsKey(id))
                {
                    if (eventsById[id].Id != id && eventsById[id].Name == eventName)
                    {
                        continue;
                    }
                    else if (eventsById[id].Id == id && eventsById[id].Name == eventName)
                    {
                        for (int i = 0; i < participantsToAdd.Count; i++)
                        {
                            if (!eventsById[id].Participants.Contains(participantsToAdd[i]))
                            {
                                eventsById[id].Participants.Add(participantsToAdd[i]);
                            }
                        }
                    }
                }
            }

            foreach (var eventEntry in eventsById
                .OrderByDescending(id => id.Value.Participants.Count)
                .ThenBy(id => id.Value.Name)
                .ThenBy(id => id.Value.Participants))
            {
                Event ev = eventEntry.Value;
                Console.WriteLine($"{ev.Name} - {ev.Participants.Count}");

                foreach (var participant in eventEntry.Value.Participants.OrderBy(x => x))
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}
