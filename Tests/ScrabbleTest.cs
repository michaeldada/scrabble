using System.Collections.Generic;
using Xunit;
namespace Scrabble.Objects
{
  public class ScrabbleTest
  {
    [Fact]
    public void ScrabbleScore_ValueOfSingleLetterZ_10()
    {
      ScrabbleWord newScrabbleWord = new ScrabbleWord("z");
      Assert.Equal(newScrabbleWord.ScrabbleScore(), 10);
    }
    
  }
}
