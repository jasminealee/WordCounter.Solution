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
		public void CheckString_IsThisWordAString_Bool()
	  {
			 string userEnterWord = "Camping";
			 bool result = userEnterWord is string;
			 Assert.AreEqual(true, result);
		}

		[TestMethod]
		public void CheckString_IsThisSentenceAString_Bool()
		{
			string userInputPhrase = "Is this phrase a string";
			bool result = userInputPhrase is string;
			Assert.AreEqual(true, result);
		}

		[TestMethod]
		public void CheckPuncutation_IsThisAPuncuation_Bool()
		{
			string punctuation = ".";
			bool result = punctuation is string;
			Assert.AreEqual(true, result);
		}
	}
}
