namespace nikstra.SqlUtilities
{
    public interface ISelectClause : IClause
	{
		IFromClause Select(string column);
		IFromClause Select(string column, string alias);
	}
}
