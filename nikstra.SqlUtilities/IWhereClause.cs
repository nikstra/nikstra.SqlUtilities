namespace nikstra.SqlUtilities
{
    public interface IWhereClause : IOrderByClause, IPagination
	{
		IWhereClause Where(ISearchCondition whereExpression);
		IWhereClause WhereOr(params ISearchCondition[] whereExpression);
	}
}
