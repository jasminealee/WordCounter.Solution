using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests;
{
	[TestClass]
	public class WordCounterTests()
  {
	  [TestMethod]
		public void InputUserWord_DoesFunctionAcceptInput()
	  {
			 string InputUserWord = "Camping";
			 bool result = InputUserWord string;
			 Assert.AreEqual(true, result);
		}

		[TestMethod]
	  public void test()
    {

	     Assert.AreEqual(true, testWordCounter.IsWordCounter)
    }

  	[TestMethod]
  	public void IsWordCounter_PunctuationNotNecessaryTrue()
  	{
  	  WordCounter testWordCounter = new WordCounter();
  	  Assert.AreEqual(true, testWordCounter.IsWordCounter);
  			}
  		}
  	}

  	[TestMethod]
  	public void IsWordCounter_NumberTrue()
  	{
  	    {
  	  WordCounter testWordCounter = new WordCounter();
  	  Assert.AreEqual(true, testWordCounter.IsWordCounter);
  			}
  	}

  	[TestMethod]
  	public void IsWordCounter_CapitalizationNotNecessary()
  	{
  	    {
  	  WordCounter testWordCounter = new WordCounter();
  	  Assert.AreEqual(true, testWordCounter.IsWordCounter);
  			}
  	}

  	[TestMethod]
  	public void IsWordCounter_NoSymbolsTrue()
  	{
  	    {
  	  WordCounter testWordCounter = new WordCounter();
  	  Assert.AreEqual(true, testWordCounter.IsWordCounter);
  	    }
  	}
