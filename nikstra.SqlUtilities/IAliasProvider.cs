namespace nikstra.SqlUtilities
{
    public interface IAliasProvider
	{
		string GetUniqueAlias(string tableName);
	}
}
