using System.Collections.Generic;
using System;

namespace Scrabble.Objects
{
  public class ScrabbleWord
  {
    private string _word;
    private static Dictionary<char, int> _scoreKey = new Dictionary<char, int>
    {
      {'a', 1 },
      {'b', 3},
      {'c', 3 },
      {'d', 2},
      {'e', 1 },
      {'f', 4},
      {'g', 2 },
      {'h', 4},
      {'i', 1 },
      {'j', 8},
      {'k', 5 },
      {'l', 3},
      {'m', 3 },
      {'n', 3},
      {'o', 1 },
      {'p', 3 },
      {'q', 10},
      {'r', 1 },
      {'s', 3},
      {'t', 1 },
      {'u', 1},
      {'v', 4 },
      {'w', 4},
      {'x', 8 },
      {'y', 4},
      {'z', 10 }

    };

    public ScrabbleWord(string word)
    {
      _word = word;
    }

    public string GetWord()
    {
      return _word;
    }
    public Dictionary<char, int> GetScoreKey()
    {
      return _scoreKey;
    }

    public int ScrabbleScore()
    {
      string word = this.GetWord().ToLower();
      int score = 0;
      int letterScore = 0;

      foreach (char c in word)
      {
        _scoreKey.TryGetValue(c, out letterScore);
        score += letterScore;
      }







      return score;
    }
  }
}
