using System;
using System.Collections.Generic;

namespace WordCounter {

  public class Program
  {
    public static void Main(string[] args)
    {
      WordFindClass userFind = new WordFindClass();
      Console.WriteLine("Enter your sentence:");
      string inputtedSentence = Console.ReadLine();
      string inputtedSentence = inputtedSentence.ToLower();
      Console.WriteLine("Select your word:");
      string selectedWord = Console.ReadLine();
      string selectedWord = selectedWord.ToLower();
      userFind.StringSplitWord(selectedSentence, selectedWord);
      int total = RepeatCounter.totalFind;
    }
  }

  public class WordFindClass
  {
    public int StringSplitWord(string userTypeWord, Word)
    {
        Find(inputtedSentence, inputtedWord);
      }
      return RepeatCounter.totalFind;
    }
  }
  }
