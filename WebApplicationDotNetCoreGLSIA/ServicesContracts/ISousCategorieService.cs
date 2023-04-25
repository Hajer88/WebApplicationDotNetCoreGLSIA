using WebApplicationDotNetCoreGLSIA.Models;

namespace WebApplicationDotNetCoreGLSIA.ServicesContracts
{
    public interface ISousCategorieService
    {
        IEnumerable<ssCategorie> GetAll();
    }
}
