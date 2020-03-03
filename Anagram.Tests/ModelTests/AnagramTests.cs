
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Anagram.Models;

namespace Anagram.Tests
{
  [TestClass]
  // public class WordsTests : IDisposable
  public class WordsTests
  {
    [TestMethod]
    public void CheckWord_MatchDictionaryWords_True()
    {
      string input = "cat";
      string test = "act";

      bool result = Words.CheckWord(input, test);

      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void WordMatch_ReturnListOfMatches_List()
    {
      List<string> testList = new List<string>() { "enlist", "listen", "silent", "tinsel" };

      List<string> results = Words.WordMatch("Listen");

      CollectionAssert.AreEqual(testList, results);
    }
  }
}

