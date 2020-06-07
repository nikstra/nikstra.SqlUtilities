namespace nikstra.SqlUtilities
{
    public interface IWhereClause : IOrderByClause, IPagination
	{
		IWhereClause Where(ISqlQueryExpression whereExpression);
		IWhereClause WhereOr(params ISqlQueryExpression[] whereExpression);
	}
}
