using Xunit;
using System;
using System.Collections.Generic;

namespace FindAndReplaceApp
{
  public class FindAndReplaceTest
  {
    [Fact]
    public void FindAndReplaceTest_ForUserInputa_b()
    {
      FindAndReplace testLetter = new FindAndReplace();
      Assert.Equal("b", testLetter.FindAndReplaceResult("a", "a", "b"));
    }

    [Fact]
    public void FindAndReplaceTest_ForUserInputSelectWord_word()
    {
      FindAndReplace testWord = new FindAndReplace();
      Assert.Equal("Hello universe", testWord.FindAndReplaceResult("Hello world", "world", "universe"));
    }
  }
}
