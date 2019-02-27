using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Enter your phrase:");
      string inputPhrase = Console.ReadLine();
      string userInputPhrase = inputPhrase.ToLower();

      Console.WriteLine("Enter your word:");
      string enterWord = Console.ReadLine();
      string userEnterWord = enterWord.ToLower();

      RepeatCounter Track = new RepeatCounter();

      string[] inputArr = Track.SplitPhrase(userInputPhrase);
      int total = Track.Find(userEnterWord, inputArr);
      string tense = Track.VerbTense(total);

      Console.WriteLine('"' + userEnterWord + '"' + " appears " + total + tense);
    }
  }
}
