using Microsoft.EntityFrameworkCore;
using WebApplicationDotNetCoreGLSIA.Models;
using WebApplicationDotNetCoreGLSIA.ServicesContracts;

namespace WebApplicationDotNetCoreGLSIA.Services
{
    public class SsCategorieService : ISousCategorieService
    {
        private readonly AppDbContext _context;
        public SsCategorieService(AppDbContext _context)
        {
            this._context = _context;
        }
        public IEnumerable<ssCategorie> GetAll()
        {
            return _context.SousCategories
                .Include(c=>c.categorie).
                ToList();
        }
    }
}
