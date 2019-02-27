using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string[] SplitPhrase(string userInputPhrase)
    {
      string[] inputArr = userInputPhrase.Split(' ', '.', ',', '!', '?');
      return inputArr;
    }
    public int Find(string user, string[] userInputPhrase)
    {
      int total = 0;
      for (int i = 0; i < userInputPhrase.Length; i++)
      {
        if (user == userInputPhrase[i])
        {
          total++;
        }
      }
      return total;
    }
    public string VerbTense(int total)
    {
      string tense = "";
      if (total < 0 || 1 < total)
      {
        tense = " times.";
      }
      else if (total == 1)
      {
        tense = " time.";
      }
      return tense;
    }
  }
}
