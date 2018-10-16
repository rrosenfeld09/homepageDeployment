using Microsoft.AspNetCore.Mvc;

namespace HomePage.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("skydive")]
        public IActionResult Skydive()
        {
            return Redirect("http://www.letsgoskydive.com");
        }

        [HttpGet("rockclimb")]
        public IActionResult RockClimb()
        {
            return Redirect("http://www.rvarockclimbers.com");
        }
    }
}
