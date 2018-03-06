using AutoMapper;
using System;
using TestEnumModel.Models;

namespace TestEnumModel
{
    public class TestEnumMapperProfile : Profile
    {
        public TestEnumMapperProfile()
        {
            CreateMap<MyEntity, MyEntityDto>();

            CreateMap<Enum, NamedEntityDto>()
                .ForMember(dest => dest.Id,
                            opt => opt.Ignore())
                            //opt => opt.MapFrom(src => src))
                .ForMember(dest => dest.Name,
                            opt => opt.MapFrom(src => src.ToString()));

            //CreateMap<Enum, NamedEnumDto>()
            //    .ForMember(dest => dest.EnumValue,
            //                opt => opt.MapFrom(src => src))
            //    .ForAllOtherMembers(opt => opt.Ignore());
        }
    }
}
