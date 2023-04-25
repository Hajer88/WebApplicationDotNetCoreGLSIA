using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationDotNetCoreGLSIA.ServicesContracts;

namespace WebApplicationDotNetCoreGLSIA.Controllers.APIControllers
{
 
    public class SsCategorieController : CustomController
    {
        private readonly ISousCategorieService sousCategorieService;

        public SsCategorieController(ISousCategorieService sousCategorieService)
        {
            this.sousCategorieService = sousCategorieService;
        }
        [HttpGet]
        public IActionResult TestSousCat()
        {
            var sscats = sousCategorieService.GetAll();
            return Ok(sscats);
        }
    }
}
