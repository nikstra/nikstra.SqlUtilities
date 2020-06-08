namespace nikstra.SqlUtilities
{
    public interface ITableSource
	{
		string Schema { get; }
		string Name { get; }
		string Alias { get; }
	}
}
