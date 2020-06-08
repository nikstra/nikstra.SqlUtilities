namespace nikstra.SqlUtilities
{
    public interface ISearchCondition
	{
		string Expression { get; }
		ISearchCondition And(ISearchCondition expression);
		ISearchCondition Or(ISearchCondition expression);
		ISearchCondition Not(ISearchCondition expression);
	}
}
