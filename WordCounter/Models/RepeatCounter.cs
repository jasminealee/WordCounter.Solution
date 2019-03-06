using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private static string _phrase;
    private static string _word;
    private static int _counter;

    public RepeatCounter (string phrase, string word, int counter)
    {
      _phrase = phrase;
      _word = word;
      _counter = counter;
    }

    public static string GetPhrase()
    {
      return _phrase;
    }

    public static string GetWord()
    {
      return _word;
    }

    public static int GetCounter()
    {
      return _counter;
    }

    public int Count(string phrase, string word, int counter)
    {
      string[] wordsInPhrase = phrase.Split(' ', '.', ',', '!', '?');
      for (int i = 0; i < wordsInPhrase.Length; i++)
      {
        if(word == wordsInPhrase[i])
        {
          counter++;
        }
      }
      _counter = counter;
      return _counter;
    }
  }
}
