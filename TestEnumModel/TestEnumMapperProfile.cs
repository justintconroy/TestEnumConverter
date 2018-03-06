using AutoMapper;
using System;
using TestEnumModel.Models;

namespace TestEnumModel
{
    public class TestEnumMapperProfile : Profile
    {
        public TestEnumMapperProfile()
        {
            CreateMap<MyEntity, MyEntityDto>()
                .ForMember(dest => dest.MyEnumField,
                            opt => opt.MapFrom(src => src.MyEnum))
                .ForMember(dest => dest.MyEnum,
                            opt => opt.Ignore())
                .ForMember(dest => dest.OtherEnumField,
                            opt => opt.MapFrom(src => src.OtherEnum))
                .ForMember(dest => dest.OtherEnum,
                            opt => opt.Ignore());

            CreateMap<Enum, NamedEntityDto>()
                .ForMember(dest => dest.Id,
                            //opt => opt.Ignore())
                            opt => opt.MapFrom(src => src))
                .ForMember(dest => dest.Name,
                            opt => opt.MapFrom(src => src.ToString()));

            //CreateMap<Enum, NamedEnumDto>()
            //    .ForMember(dest => dest.EnumValue,
            //                opt => opt.MapFrom(src => src))
            //    .ForAllOtherMembers(opt => opt.Ignore());
        }
    }
}
