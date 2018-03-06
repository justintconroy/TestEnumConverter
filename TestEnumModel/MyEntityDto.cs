namespace TestEnumModel
{
    public class MyEntityDto
    {
        public int Id { get; set; }
        public NamedEntityDto MyEnum { get; set; }
        public NamedEntityDto OtherEnum { get; set; }
    }
}
