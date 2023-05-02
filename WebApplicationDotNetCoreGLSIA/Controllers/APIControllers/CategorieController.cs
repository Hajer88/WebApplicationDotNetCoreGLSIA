using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using WebApplicationDotNetCoreGLSIA.Models;
using WebApplicationDotNetCoreGLSIA.Models.DTO;
using WebApplicationDotNetCoreGLSIA.ServicesContracts;

namespace WebApplicationDotNetCoreGLSIA.Controllers.APIControllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class CategorieController : CustomController
    {
        private readonly ICategorieService categorieService;
        public CategorieController(ICategorieService categorieService)
        {
            this.categorieService = categorieService;
        }

        [HttpGet]
        //[Route("/getall")]
     
        public async Task<IActionResult> GetAllCat()
        {
            var t = await categorieService.GEtAll();
            return Ok(t);
        }
        [HttpPost]
        
        public async Task<IActionResult> CreateCat(CategorieDTO cat)
        {
            var c = await categorieService.Create(cat);
            return Ok(c);
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult EditCat(Guid id, CategorieDTO c)
        {
            var x = categorieService.Edit(id, c);
            return Ok(x);
        }
        [HttpDelete]
        public IActionResult DeleteCat(Guid id)
        {
            categorieService.Delete(id);
            return Ok();
        }
    
    }
}
