using System.Data.Entity.Migrations;
using TestEnumModel.Models;

namespace TestEnumModel.Migrations
{
	public class Configuration : DbMigrationsConfiguration<TestEnumContext>
	{
        protected override void Seed(TestEnumContext context)
        {
            context.MyEntities.AddOrUpdate(x => x.Id,
                new MyEntity() { Id = 1, MyEnum = MyEnum.one, OtherEnum = OtherEnum.A },
                new MyEntity() { Id = 2, MyEnum = MyEnum.two, OtherEnum = OtherEnum.B },
                new MyEntity() { Id = 3, MyEnum = MyEnum.three, OtherEnum = OtherEnum.C });
        }
    }
}
