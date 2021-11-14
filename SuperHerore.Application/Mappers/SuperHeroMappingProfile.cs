using AutoMapper;
using SuperHero.Core.Entities;
using SuperHerore.Application.Responses;

namespace SuperHerore.Application.Mappers
{
    public class SuperHeroMappingProfile:Profile
    {
        public SuperHeroMappingProfile()
        {
            CreateMap<Search, SearchResponse>().ReverseMap();
            
        }
    }
}
