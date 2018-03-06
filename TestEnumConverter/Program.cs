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

                Enum value = MyEnum.one;

                // Doesn't compile
                //MyEnum enumValue = value;

                var intValue = Convert.ToInt32(value);
                var stringValue = value.ToString();

                // This doesn't work.
                var list = myEntities.ProjectTo<MyEntityDto>().ToList();


                Console.WriteLine($"Singular Result: {result}");
                Console.WriteLine("==========================");
                Console.Write("List Results:");

                foreach (var val in list)
                {
                    Console.WriteLine(val);
                }
            }
        }
    }
}
