using System;
using System.Collections.Generic;

namespace FindAndReplaceApp
{
  public class FindAndReplace
  {
    public string FindAndReplaceResult(string sentence, string selectedWord, string replacedWord)
    {
      sentence = sentence.Replace(selectedWord, replacedWord);
      return sentence;
    }
  }
}
