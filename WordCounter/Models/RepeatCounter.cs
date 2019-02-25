using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string SplitSentence(string words)
    {
      string[] userArr = words.Split();
      return userArr;
    }
    public int Find(string user, string[] words)
    {
      int total = 0;
      for (int i = 0; i < words.Length; i++)
      {
        if (user == words[i])
        {
          total++;
        }
      }
      return total;
    }
  }
}
