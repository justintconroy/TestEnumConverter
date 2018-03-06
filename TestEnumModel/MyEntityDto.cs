namespace TestEnumModel
{
    public class MyEntityDto
    {
        public int Id { get; set; }
        //public NamedEntityDto MyEnum { get; set; }
        //public NamedEntityDto OtherEnum { get; set; }
        public NamedEnumDto MyEnum { get; set; }
        public NamedEnumDto OtherEnum { get; set; }
    }
}
