using System.Collections.Generic;
using System;

namespace Scrabble.Objects
{
  public class ScrabbleWord
  {
    private string _word;
    private static Tuple<string, int>[] _scoreKey = new Tuple<string, int> 
    {
      Tuple.Create("a", 1 ),
      Tuple.Create("b", 3),
      Tuple.Create("c", 3 ),
      Tuple.Create("d", 2),
      Tuple.Create("e", 1 ),
      Tuple.Create("f", 4),      
      Tuple.Create("g", 2 ),
      Tuple.Create("h", 4),
      Tuple.Create("i", 1 ),
      Tuple.Create("j", 8),
      Tuple.Create("k", 5 ),
      Tuple.Create("l", 3),
      Tuple.Create("m", 3 ),
      Tuple.Create("n", 3),
      Tuple.Create("o", 1 ),
      Tuple.Create("p", 3 ),
      Tuple.Create("q", 10),
      Tuple.Create("r", 1 ),
      Tuple.Create("s", 3),
      Tuple.Create("t", 1 ),
      Tuple.Create("u", 1),
      Tuple.Create("v", 4 ),
      Tuple.Create("w", 4),     
      Tuple.Create("x", 8 ),
      Tuple.Create("y", 4),
      Tuple.Create("z", 10 ),

    };

    public ScrabbleWord(string word)
    {
      _word = word;
    }

    public string GetWord()
    {
      return _word;
    }
    public string GetScoreKey()
    {
      return _scoreKey;
    }

    public int ScrabbleScore()
    {
      int score = 0;



      return score;
    }
  }
}
