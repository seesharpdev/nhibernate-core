using System;
using System.Text;

using NHibernate.Type;
using NHibernate.SqlCommand;


namespace NHibernate.Expression
{
	public class RowCountProjection : SimpleProjection
	{
		protected internal RowCountProjection() { }

		public override IType[] GetTypes(ICriteria criteria, ICriteriaQuery criteriaQuery)
		{
			return new IType[] { NHibernateUtil.Int32 };
		}

		public override SqlString ToSqlString(ICriteria criteria, int position, ICriteriaQuery criteriaQuery)
		{
            SqlStringBuilder result = new SqlStringBuilder()
				.Add("count(*) as y")
				.Add(position.ToString())
				.Add("_");
            return result.ToSqlString();
		}

		public override string ToString()
		{
			return "count(*)";
		}

	}
}