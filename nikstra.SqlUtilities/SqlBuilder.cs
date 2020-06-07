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
				.InnerJoin("group", default(ISqlQueryExpression))
				.LeftJoin("site", default(ISqlQueryExpression))
				.Where(default(ISqlQueryExpression).Or(default(ISqlQueryExpression)))
				.WhereOr(default(ISqlQueryExpression), default(ISqlQueryExpression))
				.Where(default(ISqlQueryExpression))
				.OrderBy("user")
				.Paging(0, 50);
		}
	}
}
