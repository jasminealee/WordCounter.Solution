using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Enter your sentence:");

      string inputSentence = Console.ReadLine().ToLower();

      Console.WriteLine("Select your word:");
      string selectWord = Console.ReadLine().ToLower();

      RepeatCounter Track = new RepeatCounter();

      string[] userArr = Track.SplitSentence(inputSentence);
      int total = Track.Find(selectWord, userArr);
      Console.WriteLine(selectWord + " " + "appears" + " " + total + ".");
    }
  }
}
