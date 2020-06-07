namespace nikstra.SqlUtilities
{
    public interface ISqlQueryExpression
	{
		string Expression { get; }
		ISqlQueryExpression And(ISqlQueryExpression expression);
		ISqlQueryExpression Or(ISqlQueryExpression expression);
	}
}
