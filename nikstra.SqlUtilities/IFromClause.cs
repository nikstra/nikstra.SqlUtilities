namespace nikstra.SqlUtilities
{
    public interface IFromClause : ISelectClause, IAliasClause
	{
		ITableClause From(string table);
		ITableClause From(string table, string alias);
	}
}
