using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using TestEnumModel;
using TestEnumModel.Models;

namespace TestEnumConverter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Mapper.Initialize(cfg =>
                cfg.AddProfile(new TestEnumMapperProfile()));

            using (var context = new TestEnumContext())
            {
                var myEntities = context.MyEntities;

                // This works.
                var result = Mapper.Map<MyEntityDto>(myEntities.FirstOrDefault());

                // This hopefully works.
                //var linq = myEntities
                //    .Select(e => new MyEntityDto
                //    {
                //        Id = e.Id,
                //        MyEnum = new NamedEnumDto()
                //        {
                //            EnumValue = e.MyEnum
                //        },
                //        OtherEnum = new NamedEnumDto()
                //        {
                //            EnumValue = e.OtherEnum
                //        }
                //    }).ToList();

                // This doesn't work.
                var list = myEntities.ProjectTo<MyEntityDto>().ToList();

            }
        }
    }
}
