using System.Reflection.Metadata.Ecma335;

namespace WebApplicationDotNetCoreGLSIA.Models
{
    public class ssCategorie
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CategorieId { get; set; }

        public Categorie categorie { get; set; }
    }
}
    