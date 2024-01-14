using AutoMapper;
using DtoLayer.FeatureDto;
using EntityLayer.Entities;

namespace API.Mapping
{
    public class FeatureMapping: Profile


    {
        public FeatureMapping()
        {
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, GetFeatureDto>().ReverseMap();
        }

    }
}
