using Microsoft.AspNetCore.Mvc;
using UCMS.Website.Models;

namespace UCMS.Website.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IConfiguration _configuration;

        public AuthenticationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            // check if the user exists with the given username and password from the User table in db.


            //If the user exists.
            if (user != null)
            {
                HttpContext.Session.SetString("Username", user.Password);

                //assign the role on behalf of roleid
                var role = "role";

                HttpContext.Session.SetString("Role", role);
                return RedirectToAction("ActionName", "ControllerName");
            }


            //if the username or password is wrong or the user does not exist
            ViewBag.Error = "Invalid login credentials.";

            return View();            
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
