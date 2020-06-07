namespace nikstra.SqlUtilities
{
    public interface IPagination : IClause
	{
		void Paging(int skip, int take);
	}
}
