using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationDotNetCoreGLSIA.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        //private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }


        //Lister tous les utilisateurs de ASPNetUsers
        public IActionResult Index()
        {
            return View(_userManager.Users);
        }
    }
}
