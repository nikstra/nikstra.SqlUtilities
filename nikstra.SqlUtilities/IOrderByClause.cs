namespace nikstra.SqlUtilities
{
    public interface IOrderByClause : IClause
	{
		IPagination OrderBy(params string[] columns);
		IPagination OrderByAscending(params string[] columns);
		IPagination OrderByDescending(params string[] columns);
	}
}
