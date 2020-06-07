namespace nikstra.SqlUtilities
{
    public interface ISqlQuery : IClause, ISelectClause, IFromClause, IJoinClause, IWhereClause
	{
		string Query { get; }
	}
}
