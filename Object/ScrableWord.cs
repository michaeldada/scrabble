using System.Collections.Generic;
using System;

namespace Scrabble.Objects
{
  public class Scrabble
  {
    private string _word;

    public Scrabble(string word)
    {
      _word = word;
    }

    public string GetWord()
    {
      return _word;
    }

    public int ScrabbleScore()
    {
      int score = 0;

      return score;
    }
  }
}
