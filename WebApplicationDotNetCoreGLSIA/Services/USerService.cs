using Microsoft.AspNetCore.Identity;
using WebApplicationDotNetCoreGLSIA.Models;
using WebApplicationDotNetCoreGLSIA.ServicesContracts;

namespace WebApplicationDotNetCoreGLSIA.Services
{
    public class USerService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public USerService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public IEnumerable<ApplicationUser> GetAllUsers()
        {
            return _userManager.Users;            
        }
    }
}
