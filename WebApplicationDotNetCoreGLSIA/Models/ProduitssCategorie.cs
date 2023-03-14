namespace WebApplicationDotNetCoreGLSIA.Models
{
    public class ProduitssCategorie
    {
        public Guid ProduitId { get; set; }
        public Guid ssCategorieId { get; set; }
        public Produit produit { get; set; }

        public ssCategorie sscateg { get; set; }
        public DateTime DateAjout { get; set; }
    }
}
