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
        string output = "output";
        return View["output.cshtml", output];
      };
    }
  }
}
