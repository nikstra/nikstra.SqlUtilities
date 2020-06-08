namespace nikstra.SqlUtilities
{
    public interface IJoinClause : IClause
	{
		ITableClause InnerJoin(string table, ISearchCondition onExpression);
		ITableClause InnerJoin(string table, ISearchCondition onExpression, string alias);
		ITableClause LeftJoin(string table, ISearchCondition onExpression);
		ITableClause LeftJoin(string table, ISearchCondition onExpression, string alias);
	}
}
