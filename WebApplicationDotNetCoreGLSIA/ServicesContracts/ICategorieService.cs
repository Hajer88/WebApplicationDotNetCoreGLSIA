using WebApplicationDotNetCoreGLSIA.Models;
using WebApplicationDotNetCoreGLSIA.Models.DTO;

namespace WebApplicationDotNetCoreGLSIA.ServicesContracts
{
    public interface ICategorieService
    {
        Task<List<CategorieDTO>> GEtAll();
        Task<CategorieDTO> Create(CategorieDTO cat);
        CategorieDTO Edit(Guid id, CategorieDTO c);

        void Delete(Guid id);
    }
}
