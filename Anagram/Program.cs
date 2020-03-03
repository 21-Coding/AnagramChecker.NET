using System;
using System.Collections.Generic;
using Anagram.Models;

namespace Anagram
{
  class Program
  {
    public static void QuickText(string line)
    {
      for (int i = 0; i < line.Length; i++)
      {
        Console.Write(line[i]);
        System.Threading.Thread.Sleep(50);
      }
    }
    static void Main(string[] args)
    {
      QuickText(@"Is your word an Anagram?
      Enter : ");

      string input = Console.ReadLine();

      List<string> wordList = Words.WordMatch(input);
      int i = 0;
      foreach (var item in wordList)
      {
        ++i;
        QuickText($"{i}. {item} \n");
      }
    }
  }
}
