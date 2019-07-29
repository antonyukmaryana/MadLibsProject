using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
        

       [Route("/form")]
        public ActionResult MadLibsForm() { return View(); }

        [Route("/madlibs")]
        public ActionResult MadLibs(string adjective, string pluralnoun,string noun,string adverb,string number,string pasttenseverb, string estadjective)
        {
            MadLibsVariable myMadLibsVariable = new MadLibsVariable();
            myMadLibsVariable.Adjective = adjective;
            myMadLibsVariable.PluralNoun = pluralnoun;
            myMadLibsVariable.Noun = noun;
            myMadLibsVariable.Adverb = adverb;
            myMadLibsVariable.Number = number;
            myMadLibsVariable.PastTenseVerb = pasttenseverb;
            myMadLibsVariable.EstAdjective = estadjective;
            
            return View(myMadLibsVariable);
        }
    }
}

