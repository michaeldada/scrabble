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
        
        return View["output.cshtml", output];
      };
    }
  }
}
