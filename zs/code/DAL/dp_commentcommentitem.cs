using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ;
using Model;
using Dapper;
namespace DAL
{
	/// <summary>
	/// 数据访问类:dp_commentcommentitem
	/// </summary>
	public partial class dp_commentcommentitem
	{
		public dp_commentcommentitem()
		{}
		#region  Method

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(dp_commentcommentitem model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("select count(1) from dp_commentcommentitem");
			strSql.Append("  where commentid=@commentid and commentitemid=@commentitemid and expect=@expect and real=@real ");
			using (IDbConnection conn = DapperHelper.OpenConnection())
			{
				int count = conn.Execute(strSql.ToString(), model);
				if (count > 0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(dp_commentcommentitem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into dp_commentcommentitem(");
			strSql.Append("commentid,commentitemid,expect,real)");
			strSql.Append(" values (");
			strSql.Append("@commentid,@commentitemid,@expect,@real)");
			using (IDbConnection conn = DapperHelper.OpenConnection())
			{
				int count = conn.Execute(strSql.ToString(), model);
				if (count > 0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(dp_commentcommentitem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update dp_commentcommentitem set ");
			strSql.Append(" where commentid=@commentid and commentitemid=@commentitemid and expect=@expect and real=@real ");
			using (IDbConnection conn = DapperHelper.OpenConnection())
			{
				int count = conn.Execute(strSql.ToString(), model);
				if (count > 0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(dp_commentcommentitem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from dp_commentcommentitem ");
			strSql.Append(" where commentid=@commentid and commentitemid=@commentitemid and expect=@expect and real=@real " );
			using (IDbConnection conn = DapperHelper.OpenConnection())
			{
				int count = conn.Execute(strSql.ToString(), model);
				if (count > 0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public dp_commentcommentitem GetModel(int commentid,int commentitemid,int expect,int real)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" commentid,commentitemid,expect,real ");
			strSql.Append(" from dp_commentcommentitem ");
			strSql.Append(" where commentid="+commentid+" and commentitemid="+commentitemid+" and expect="+expect+" and real="+real+" " );
			dp_commentcommentitem model=new dp_commentcommentitem();
			DataSet ds=.Query(strSql.ToString());
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public dp_commentcommentitem DataRowToModel(DataRow row)
		{
			dp_commentcommentitem model=new dp_commentcommentitem();
			if (row != null)
			{
				if(row["commentid"]!=null && row["commentid"].ToString()!="")
				{
					model.commentid=int.Parse(row["commentid"].ToString());
				}
				if(row["commentitemid"]!=null && row["commentitemid"].ToString()!="")
				{
					model.commentitemid=int.Parse(row["commentitemid"].ToString());
				}
				if(row["expect"]!=null && row["expect"].ToString()!="")
				{
					model.expect=int.Parse(row["expect"].ToString());
				}
				if(row["real"]!=null && row["real"].ToString()!="")
				{
					model.real=int.Parse(row["real"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select commentid,commentitemid,expect,real ");
			strSql.Append(" FROM dp_commentcommentitem ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return .Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" commentid,commentitemid,expect,real ");
			strSql.Append(" FROM dp_commentcommentitem ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return .Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM dp_commentcommentitem ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.real desc");
			}
			strSql.Append(")AS Row, T.*  from dp_commentcommentitem T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return .Query(strSql.ToString());
		}

		/*
		*/

		#endregion  Method
	}
}

