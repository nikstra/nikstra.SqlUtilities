namespace nikstra.SqlUtilities
{
    public interface IAliasClause : IClause
	{
		ITableClause As(string alias);
	}
}
