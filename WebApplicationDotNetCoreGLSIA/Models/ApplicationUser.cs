using Microsoft.AspNetCore.Identity;

namespace WebApplicationDotNetCoreGLSIA.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string City { get; set; }
    }
}
