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
    [Fact]
    public void Scrabble_ValueOfZap_14()
    {
      ScrabbleWord newScrabbleWord = new ScrabbleWord("zap");
      Assert.Equal(newScrabbleWord.ScrabbleScore(), 14);
    }
    [Fact]
    public void Scrabble_ValueOfcRaZy_19()
    {
      ScrabbleWord newScrabbleWord = new ScrabbleWord("cRaZy");
      Assert.Equal(newScrabbleWord.ScrabbleScore(), 19);
    }

  }
}
