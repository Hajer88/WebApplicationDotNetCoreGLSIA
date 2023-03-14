using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationDotNetCoreGLSIA.Models;

namespace WebApplicationDotNetCoreGLSIA.Controllers
{
    public class CategorieController : Controller
    {
        private readonly AppDbContext _context;
        public CategorieController(AppDbContext _context)
        {
            this._context = _context;
        }
        //Lister tous les catégories
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Categorie c)
        {
            _context.Categories.Add(c);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Edit(Guid? id)
        {
            if (id == null) return NotFound();
            var categorie = _context.Categories.FirstOrDefault(c => c.Id == id);
            return View(categorie);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Categorie c)
        {
            //var  =_context.Categories.FirstOrDefault(c => c.Id == id);
            _context.Categories.Update(c);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));


        }

        public IActionResult DowloadFile()
        {
            byte[] bytes = System.IO.File
                .ReadAllBytes(@"C:\Users\TEK-UP\Desktop\Document.pdf");
            return File(bytes, "application/pdf");
        }
       
        public IActionResult Delete(Guid id)
        {
            //if (id == null) return NotFound();
            var c = _context.Categories.Find(id);            
            _context.Categories.Remove(c);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        //[HttpPost,ActionName("Delete")]
        //public IActionResult DeleteConfirmed(Guid? id)
        //{
        //    if(id == null) return NotFound();
        //    var c = _context.Categories.Find(id);
        //    _context.Categories.Remove(c);
        //    _context.SaveChanges();
        //    return RedirectToAction(nameof(Index));
        //}
    }
}
