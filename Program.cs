using System;
using System.Collections.Generic;

namespace family_dictionary
{
  class Program
  {
    static void Main(string[] args)
    {
      //   FAMILY DICTIONARY EXERCISE
      //   Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
      //   myFamily.Add("me", new Dictionary<string, string>() { { "name", "james" }, { "age", "27" } });
      //   myFamily.Add("sister", new Dictionary<string, string>() { { "name", "karis" }, { "age", "31" } });
      //   myFamily.Add("wife", new Dictionary<string, string>() { { "name", "Asia" }, { "age", "28" } });
      //   foreach (KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
      //   {
      //     if (familyMember.Value["name"] == "james")
      //     {
      //       Console.WriteLine($"I'm {familyMember.Value["name"]} and I'm {familyMember.Value["age"]}");
      //     }
      //     else
      //     {
      //       Console.WriteLine($"{familyMember.Value["name"]} is my {familyMember.Key} and is {familyMember.Value["age"]} years old");
      //     }
      //   }

      //Planets AND PROBES EXERCISE
      List<string> planetList = new List<string>() { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };

      List<KeyValuePair<string, string>> probeDestinations = new List<KeyValuePair<string, string>>()
      {
           KeyValuePair.Create("Mercury", "merc1"),
           KeyValuePair.Create("Mercury", "merc2"),
           KeyValuePair.Create("Venus", "Venusian1"),
           KeyValuePair.Create("Mars", "prob3"),
           KeyValuePair.Create("Jupiter", "Jupiter1"),
           KeyValuePair.Create("Saturn", "RingWrangler"),
           KeyValuePair.Create("Uranus", "ewwwww"),
           KeyValuePair.Create("Neptune", "Poseidon"),
        };
      //probeDestinations.Add(new KeyValuePair<string, string>("Mercury", "Merc1"));
      foreach (string planet in planetList)
      {
        List<string> matchingProbes = new List<string>();
        foreach (KeyValuePair<string, string> probe in probeDestinations)
        {
          if (probe.Key == planet)
          {
            matchingProbes.Add(probe.Value);
          }
        }
        string joinedProbes = string.Join(", ", matchingProbes);
        Console.WriteLine($"{planet}: {joinedProbes} ");
      }




    }
  }
}
