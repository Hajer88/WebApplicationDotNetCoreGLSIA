namespace WebApplicationDotNetCoreGLSIA.Models
{
    public class PanierByUser
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public Guid ProduitId { get; set; }
        public List<Produit> produits { get; set; }
    }
}
