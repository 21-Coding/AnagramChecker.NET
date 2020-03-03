
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
    // public void Dispose()
    // {
    //   // clear
    // }
    [TestMethod]
    public void WordMatch_ReturnsTrueIfExists_True()
    {
      //arrange
      string inputWord = "apple";
      bool result = Words.WordMatch(inputWord);

      Assert.AreEqual(true, result);
    }
  }
}

