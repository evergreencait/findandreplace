using System;
using System.Collections.Generic;

namespace FindAndReplaceApp
{
  public class FindAndReplace
  {
    public string FindAndReplaceResult(string sentence, string selectedWord, string replacedWord)
    {
      // string selectedWordAltered = selectedWord.ToLower();

      if (sentence.Contains(" "))
      {
        string[] split = sentence.Split(' ');

        for (int i = 0; i < split.Length; i++)
        {
          // string splitAltered = split[i].ToLower();
          if (split[i].Contains(selectedWord))
          {
            split[i] = split[i].Replace(selectedWord, replacedWord);
          }
        }
        sentence = string.Join(" ", split);
      }
      else
      {
        sentence = sentence.Replace(selectedWord, replacedWord);
      }
      return sentence;
    }
  }
}
