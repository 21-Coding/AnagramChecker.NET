using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;



namespace Anagram.Models
{
  public class Words
  {
    private static IEnumerable<String> wordList = File.ReadLines("/Users/Guest/Desktop/Anagram.Solution/Anagram/Models/dictionary.txt");
    public static List<string> WordMatch(string inputWord)
    {
      List<string> results = new List<string>(10);
      foreach (var item in wordList)
      {
        if (item.Length == inputWord.Length)
        {
          if (CheckWord(item, inputWord))
          {
            results.Add(item);
            // results.Add("Test");

          }
        }
      }
      return results;
    }

    public static bool CheckWord(string firstWord, string secondWord)
    {
      char[] first = firstWord.ToLower().ToCharArray();
      char[] second = secondWord.ToLower().ToCharArray();
      Array.Sort(first);
      Array.Sort(second);


      //take two words.
      //turn them into array.
      // sort array.
      //compare
      //return bool


      return first.SequenceEqual(second);
    }





  }

}