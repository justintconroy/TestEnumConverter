using AutoMapper;
using System;

namespace TestEnumModel
{
    public class MyEntityDto
    {
        public int Id { get; set; }

        public MyEnum MyEnumField { get; set; }
        public NamedEntityDto MyEnum
        {
            get
            {
                return Mapper.Map<NamedEntityDto>(MyEnumField);
            }
        }

        public OtherEnum OtherEnumField { get; set; }
        public NamedEntityDto OtherEnum
        {
            get
            {
                return Mapper.Map<NamedEntityDto>(OtherEnumField);
            }
        }

        public override string ToString()
        {
            return $"Id: {Id},\nMyEnum: {{Id: {MyEnum.Id}, Name: {MyEnum.Name}}}\n" +
                $"OtherEnum : {{Id: {OtherEnum.Id}, Name: {OtherEnum.Name}}}";
        }
    }
}
