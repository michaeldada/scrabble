using Nancy;
using Scrabble.Objects;
using System.Collections.Generic;

namespace Scrabble
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/output"] = _ => {
        ScrabbleWord newScrabbleWord = new ScrabbleWord(Request.Form["word"]);

        int output =   newScrabbleWord.ScrabbleScore();
        return View["output.cshtml", output];
      };
    }
  }
}
