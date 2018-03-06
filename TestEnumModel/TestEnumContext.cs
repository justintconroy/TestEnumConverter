using System;
using System.Data.Entity;

namespace TestEnumModel
{
    using TestEnumModel.Models;

    public class TestEnumContext : DbContext
    {
        public DbSet<MyEntity> MyEntities { get; set; }
    }

    public enum MyEnum
    {
        one = 1,
        two = 2,
        three = 3
    }

    public enum OtherEnum
    {
        A = 1,
        B = 2,
        C = 3
    }
}

namespace TestEnumModel.Models
{
    public class MyEntity
    {
        public int Id { get; set; }
        public MyEnum MyEnum { get; set; }
        public OtherEnum OtherEnum { get; set; }
    }
}
