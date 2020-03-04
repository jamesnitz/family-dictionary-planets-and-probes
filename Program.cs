using System;
using System.Collections.Generic;

namespace family_dictionary
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Meet my family!!");
      Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
      myFamily.Add("me", new Dictionary<string, string>() { { "name", "james" }, { "age", "27" } });
      myFamily.Add("sister", new Dictionary<string, string>() { { "name", "karis" }, { "age", "31" } });
      myFamily.Add("wife", new Dictionary<string, string>() { { "name", "Asia" }, { "age", "28" } });

      foreach (KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
      {
        if (familyMember.Value["name"] == "james")
        {
          Console.WriteLine($"I'm {familyMember.Value["name"]} and I'm {familyMember.Value["age"]}");
        }
        else
        {
          Console.WriteLine($"{familyMember.Value["name"]} is my {familyMember.Key} and is {familyMember.Value["age"]} years old");
        }
      }
    }
  }
}
