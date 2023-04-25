using WebApplicationDotNetCoreGLSIA.Models;

namespace WebApplicationDotNetCoreGLSIA.ServicesContracts
{
    public interface ICategorieService
    {
        Task<List<Categorie>> GEtAll();
        Task<Categorie> Create(Categorie cat);
        Categorie Edit(Guid id, Categorie c);

        void Delete(Guid id);
    }
}
