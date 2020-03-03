using System;
using System.Collections.Generic;
using System.IO;



namespace Anagram.Models
{
  public class Words
  {
    private static IEnumerable<String> wordList = File.ReadLines("/Users/Guest/Desktop/Anagram.Solution/Anagram/Models/dictionary.txt");
    public static bool WordMatch(string inputWord)
    {
      foreach (var item in wordList)
      {
        if (item == inputWord)
        {
          return true;
        }
      }
      return false;
    }
  }

}