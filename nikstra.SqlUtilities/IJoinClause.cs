namespace nikstra.SqlUtilities
{
    public interface IJoinClause : IClause
	{
		ITableClause InnerJoin(string table, ISqlQueryExpression onExpression);
		ITableClause InnerJoin(string table, ISqlQueryExpression onExpression, string alias);
		ITableClause LeftJoin(string table, ISqlQueryExpression onExpression);
		ITableClause LeftJoin(string table, ISqlQueryExpression onExpression, string alias);
	}
}
