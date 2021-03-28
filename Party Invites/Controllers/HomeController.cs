using Lab3_PartyInvites_.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Lab3_PartyInvites_.Controllers
{
    public class HomeController : Controller
    {

        //Fields & Properties


        //Constructors


        //Methods
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListResponses()
        {
            List<GuestResponse> Responses = Repository.GetResponses();
            List<GuestResponse> WillAttend = Responses.Where(r => r.WillAttend == true).OrderBy(r=> r.Name).ToList();
            return View(WillAttend);
        }


        [HttpGet]
        public IActionResult RsvpForm()
        {
            IActionResult answer = View();
            return View();
        }

        [HttpPost]
        public IActionResult RsvpForm(GuestResponse gr)
        {
            if(ModelState.IsValid)
            {
                Repository.AddResponse(gr);

                return View("Thanks", gr);
            }
            else
            {
                return View();
            }
        }
    }
}
