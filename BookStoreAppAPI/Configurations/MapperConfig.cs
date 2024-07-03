using AutoMapper;
using BookStoreAppAPI.Data;
using BookStoreAppAPI.Models.Author;

namespace BookStoreAppAPI.Configurations
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorCreateDto, Author>().ReverseMap();
            CreateMap<AuthorUpdateDto, Author>().ReverseMap();
            CreateMap<AuthorGetDto, Author>().ReverseMap();
        }

    }
}
