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
            //Dot notation syntax
            return _context.SousCategories
                
                //.Include(c=>c.categorie)

                    //.Where(c=>c.categorie.Name=="test")
                .ToList();
            //Exécution différée
            //Query syntaxe
            var test = from c in _context.SousCategories
                       select c;
            //retourne le résultat immédiat--> exécution immédiate
            
            //_context.SousCategories.Add();
            test.Count();
        }

        public IEnumerable<ssCategorie> GetssCatByCatName(string Name)
        {
            var sscatByName = _context.SousCategories
                .Where(c => c.categorie.Name == Name)
                .ToList();
            return sscatByName;
        }

        public IEnumerable<ssCategorie> GetssCatOrderBy()
        {
            return _context.SousCategories
                 .OrderByDescending(c => c.Name)
                 .ToList();
        }
    }
}
