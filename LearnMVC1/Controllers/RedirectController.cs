using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.Controllers
{
 
    //no logic just to render view
    public class RedirectController : Controller
    {
        [Route("/Common/About")]
        public IActionResult About()
        {
            return View("/Views/Common/About.cshtml");
        }

        [Route("/Common/Error")]
        public IActionResult Error()
        {
            return View("/Views/Common/Error.cshtml");
        }

        //redirect to Product ListAll and must not have Route attribute to have conventional pattern
        public IActionResult Home()
        {
            return Redirect("/Common/Product/List");
        }
    }
}
