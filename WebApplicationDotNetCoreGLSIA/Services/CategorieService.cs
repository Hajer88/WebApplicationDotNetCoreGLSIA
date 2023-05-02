using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApplicationDotNetCoreGLSIA.Models;
using WebApplicationDotNetCoreGLSIA.Models.DTO;
using WebApplicationDotNetCoreGLSIA.ServicesContracts;

namespace WebApplicationDotNetCoreGLSIA.Services
{
    public class CategorieService : ICategorieService
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper mapper;
        public CategorieService(AppDbContext _appDbContext, IMapper mapper)
        {
            this._appDbContext = _appDbContext;
            this.mapper = mapper;
        }
        public async Task<List<CategorieDTO>> GEtAll()
        {
            var c = await _appDbContext.Categories.ToListAsync();
            var cat = from t in _appDbContext.Categories
                      select new CategorieDTO()
                      {
                          Id = t.Id,
                          Name = t.Name,
                      };
            return mapper.Map<List<CategorieDTO>>(c);
        }
        public async Task<CategorieDTO> Create(CategorieDTO C)
        {

            //var r = await (from t in _appDbContext.Categories
            //        select t)
            //        .ToListAsync();
            var cat = mapper.Map<Categorie>(C);
            _appDbContext.Categories.Add(cat);
            await _appDbContext.SaveChangesAsync();
            return C;
        }

        public CategorieDTO Edit(Guid id, CategorieDTO c)
        {
            var catInDb = _appDbContext.Categories.FirstOrDefault(c => c.Id == id);
            catInDb.Name = c.Name;
            mapper.Map<CategorieDTO>(catInDb);
           // mapper.Map(catInDb, c);
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
