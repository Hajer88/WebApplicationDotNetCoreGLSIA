using Microsoft.EntityFrameworkCore;
using WebApplicationDotNetCoreGLSIA.Models;
using WebApplicationDotNetCoreGLSIA.ServicesContracts;

namespace WebApplicationDotNetCoreGLSIA.Services
{
    public class CategorieService : ICategorieService
    {
        private readonly AppDbContext _appDbContext;
        public CategorieService(AppDbContext _appDbContext)
        {
            this._appDbContext = _appDbContext;
        }
        public async Task<List<Categorie>> GEtAll()
        {
            var c = await _appDbContext.Categories.ToListAsync();
            return c;
        }
        public async Task<Categorie> Create(Categorie C)
        {
            var r = await (from t in _appDbContext.Categories
                    select t)
                    .ToListAsync();
            
            _appDbContext.Categories.Add(C);
            await _appDbContext.SaveChangesAsync();
            return C;
        }

        public Categorie Edit(Guid id, Categorie c)
        {
            var catInDb = _appDbContext.Categories.FirstOrDefault(c => c.Id == id);
            catInDb.Name = c.Name;
            
            _appDbContext.SaveChanges();
            return c;

        }

        public void Delete(Guid id)
        {
            var sscat = _appDbContext
                .SousCategories
                .Where(c => c.CategorieId == id)
                .ToList();
            foreach (var souscat in sscat)
            {
                _appDbContext.Remove(souscat);
                _appDbContext.SaveChanges();
            }
            var t = _appDbContext.Categories.Find(id);
            _appDbContext.Categories.Remove(t);
            _appDbContext.SaveChanges();
        }
    }
}
