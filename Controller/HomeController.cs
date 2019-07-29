using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
        

       [Route("/form")]
        public ActionResult MadLibsForm() { return View(); }

        [Route("/FunParkStory")]
        public ActionResult FunParkStory() { return View(); }

        [Route("/ArcadeStory")]
        public ActionResult ArcadeStory() { return View(); }
        

        [Route("/FunPark")]
        public ActionResult FunPark(string adjective, string pluralnoun,string noun,string adverb,string number,string pasttenseverb, string estadjective)
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

        [Route("/Arcade")]
        public ActionResult Arcade(string pluralnoun, string noun,  string ingverb, string verb)
        {
            MadLibsVariable myMadLibsVariable1 = new MadLibsVariable();
            myMadLibsVariable1.PluralNoun = pluralnoun;
            myMadLibsVariable1.Noun = noun;
            myMadLibsVariable1.Verb = verb;
            myMadLibsVariable1.IngVerb = ingverb;

            return View(myMadLibsVariable1);
        }
    }
}

