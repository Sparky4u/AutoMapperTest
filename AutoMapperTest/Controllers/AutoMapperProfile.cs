using AutoMapper;
using AutoMapperTest.Models;

namespace AutoMapperTest.Controllers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<SuperHero, SuperHeroDto>();
            CreateMap<SuperHeroDto, SuperHero>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SuperHero, SuperHeroDto>();
                //cfg.AddProfile<AutoMapperProfile>;
            });
        }
        
    }
}
