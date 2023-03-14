using System.ComponentModel.DataAnnotations;

namespace WebApplicationDotNetCoreGLSIA.Models
{
    public class Categorie
    {
        public Guid Id { get; set; }
        [Display(Name ="Name of Categorie")]
        public string Name { get; set; }
    }
}
