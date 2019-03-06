using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests
{
	[TestClass]
	public class WordCounterTests
  {
	  [TestMethod]
		public void CheckString_IsThisWordAString_True()
	  {
			 string userInputWord = "word";
			 bool word = userInputWord is string;
			 Assert.AreEqual(true, word);
		}

		[TestMethod]
		public void CheckString_IsThisPhraseAString_True()
		{
			string userInputPhrase = "Is this phrase a string";
			bool phrase = userInputPhrase is string;
			Assert.AreEqual(true, phrase);
		}

		[TestMethod]
		public void CheckCounter_Instances_CounterEqual2()
		{
			int counter = 0;
			string phrase = "hi there";
			string word = "hi";
			RepeatCounter myRepeatCounter = new RepeatCounter(phrase, word, counter);
			myRepeatCounter.Count(phrase, word, counter);
			Assert.AreEqual(1, myRepeatCounter.Count(phrase, word, counter));
		}

		[TestMethod]
		public void CheckString_Instances_CounterEqual5()
		{
			int counter = 0;
			string phrase = "hi hi.hi,hi!hi?";
			string word = "hi";
			RepeatCounter myRepeatCounter = new RepeatCounter(phrase, word, counter);
			myRepeatCounter.Count(phrase, word, counter);
			Assert.AreEqual(5, myRepeatCounter.Count(phrase, word, counter));
		}
	}
}
