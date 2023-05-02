using Microsoft.AspNetCore.Identity;
using WebApplicationDotNetCoreGLSIA.Models;

namespace WebApplicationDotNetCoreGLSIA.ServicesContracts
{
    public interface IUserService
    {
        public IEnumerable<ApplicationUser> GetAllUsers();
    }
}
