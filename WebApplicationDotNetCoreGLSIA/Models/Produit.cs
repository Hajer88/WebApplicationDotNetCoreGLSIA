namespace WebApplicationDotNetCoreGLSIA.Models
{
    public class Produit
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public  string? ImageFile { get; set; }
        public DateTime? DateAjoutProduit { get; set; }
        public ICollection<ssCategorie>? sscategs { get; set; }
        //public ICollection<ProduitssCategorie> produitsscateg { get; set; }
    }
}
