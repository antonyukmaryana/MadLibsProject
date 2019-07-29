using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;

namespace ProjectName.Controllers
{
    public class HomeController : Controller
    {
        

       [Route("/")]
        public ActionResult ProjectForm() { return View(); }

        [Route("/projectname")]
        public ActionResult ProjectName(string recipient)
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.Recipient = recipient;
            
            return View(myLetterVariable);
        }
    }
}

