using AutoMapper;
using DtoLayer.AboutDto;
using EntityLayer.Entities;
using System.Runtime;

namespace API.Mapping
{
    public class AboutMapping: Profile
    {
        public AboutMapping()
        {
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, GetAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
        }


    }
}
