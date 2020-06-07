namespace nikstra.SqlUtilities
{
    public interface ISqlTableExpression
	{
		string Alias { get; }
		string Name { get; }
	}
}
