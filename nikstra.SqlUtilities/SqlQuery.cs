using System;
using System.Collections.Generic;

namespace nikstra.SqlUtilities
{
    public class SqlQuery : ISqlQuery
	{
		private IList<IClause> _clauses;

		public string Query { get; private set; }

		public IFromClause Select(string column) { throw new NotImplementedException(); }
		public IFromClause Select(string column, string alias) { throw new NotImplementedException(); }

		ITableClause IAliasClause.As(string alias) { throw new NotImplementedException(); }

		ITableClause IFromClause.From(string table) { throw new NotImplementedException(); }
		ITableClause IFromClause.From(string table, string alias) { throw new NotImplementedException(); }

		ITableClause IJoinClause.InnerJoin(string table, ISearchCondition onExpression) { throw new NotImplementedException(); }
		ITableClause IJoinClause.InnerJoin(string table, ISearchCondition onExpression, string alias) { throw new NotImplementedException(); }
		ITableClause IJoinClause.LeftJoin(string table, ISearchCondition onExpression) { throw new NotImplementedException(); }
		ITableClause IJoinClause.LeftJoin(string table, ISearchCondition onExpression, string alias) { throw new NotImplementedException(); }

		IWhereClause IWhereClause.Where(ISearchCondition whereExpression) { throw new NotImplementedException(); }
		IWhereClause IWhereClause.WhereOr(params ISearchCondition[] whereExpression) { throw new NotImplementedException(); }

		IPagination IOrderByClause.OrderBy(params string[] columns) { throw new NotImplementedException(); }
		IPagination IOrderByClause.OrderByAscending(params string[] columns) { throw new NotImplementedException(); }
		IPagination IOrderByClause.OrderByDescending(params string[] columns) { throw new NotImplementedException(); }

		void IPagination.Paging(int skip, int take) { throw new NotImplementedException(); }
	}
}
