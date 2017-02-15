using Xunit;
using System;
using System.Collections.Generic;

namespace FindAndReplaceApp
{
  public class FindAndReplaceTest
  {
    [Fact]
    public void FindAndReplaceTest_ForUserInputSentence_sentence()
    {
      FindAndReplace testSentence = new FindAndReplace();
      Assert.Equal("Hello world", testSentence.FindAndReplaceResult("Hello world"));
    }
  }
}
