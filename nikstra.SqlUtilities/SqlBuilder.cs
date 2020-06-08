namespace nikstra.SqlUtilities
{
    public class SqlBuilder
	{
		public bool Foo() => true;

		public void Bar()
		{
			var query = new SqlQuery();
			query.Select("id")
				.Select("name")
				.From("users")
				.InnerJoin("group", default(ISearchCondition))
				.LeftJoin("site", default(ISearchCondition))
				.Where(default(ISearchCondition).Or(default(ISearchCondition)))
				.WhereOr(default(ISearchCondition), default(ISearchCondition))
				.Where(default(ISearchCondition))
				.OrderBy("user")
				.Paging(0, 50);
		}
	}
}
