using AutoMapper;
using WebApplicationDotNetCoreGLSIA.Models.DTO;

namespace WebApplicationDotNetCoreGLSIA.Models
{
    public class UserProfile :  Profile
    {
        public UserProfile()
        {
            CreateMap<Categorie, CategorieDTO>();
            CreateMap<CategorieDTO, Categorie>();
        }
    }
}
