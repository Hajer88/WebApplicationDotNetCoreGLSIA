using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplicationDotNetCoreGLSIA.Models;

namespace WebApplicationDotNetCoreGLSIA.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        //private readonly RoleManager<IdentityRole> _roleManager;

       
        public AccountController(UserManager<ApplicationUser> userManager)
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
