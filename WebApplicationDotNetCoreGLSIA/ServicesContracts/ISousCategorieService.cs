using WebApplicationDotNetCoreGLSIA.Models;

namespace WebApplicationDotNetCoreGLSIA.ServicesContracts
{
    public interface ISousCategorieService
    {
        IEnumerable<ssCategorie> GetAll();
        IEnumerable<ssCategorie> GetssCatByCatName(string Name);
        IEnumerable<ssCategorie> GetssCatOrderBy();
    }
}
