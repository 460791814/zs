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
	/// 数据访问类:dp_opinion
	/// </summary>
	public partial class dp_opinion
	{
		public dp_opinion()
		{}
		#region  Method

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(dp_opinion model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("select count(1) from dp_opinion");
			strSql.Append("  where opinionid=@opinionid");
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
		public int Add(dp_opinion model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into dp_opinion(");
			strSql.Append("opiniontypeid,opinioncontent,updatetime,isdelete)");
			strSql.Append(" values (");
			strSql.Append("@opiniontypeid,@opinioncontent,@updatetime,@isdelete)");
			strSql.Append(";select @@IDENTITY");
			using (IDbConnection conn = DapperHelper.OpenConnection())
			{
				object obj = conn.ExecuteScalar(strSql.ToString(), model);
				if (obj == null)
				{
					return 0;
				}
				else
				{
					return Convert.ToInt32(obj);
				}
			}
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(dp_opinion model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update dp_opinion set ");
			strSql.Append(" where opinionid=@opinionid");
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
		public bool Delete(dp_opinion model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from dp_opinion ");
			strSql.Append(" where opinionid=@opinionid" );
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
		}		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string opinionidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from dp_opinion ");
			strSql.Append(" where opinionid in ("+opinionidlist + ")  ");
			int rows=.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public dp_opinion GetModel(int opinionid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" opinionid,opiniontypeid,opinioncontent,updatetime,isdelete ");
			strSql.Append(" from dp_opinion ");
			strSql.Append(" where opinionid="+opinionid+"" );
			dp_opinion model=new dp_opinion();
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
		public dp_opinion DataRowToModel(DataRow row)
		{
			dp_opinion model=new dp_opinion();
			if (row != null)
			{
				if(row["opinionid"]!=null && row["opinionid"].ToString()!="")
				{
					model.opinionid=int.Parse(row["opinionid"].ToString());
				}
				if(row["opiniontypeid"]!=null && row["opiniontypeid"].ToString()!="")
				{
					model.opiniontypeid=int.Parse(row["opiniontypeid"].ToString());
				}
				if(row["opinioncontent"]!=null)
				{
					model.opinioncontent=row["opinioncontent"].ToString();
				}
				if(row["updatetime"]!=null && row["updatetime"].ToString()!="")
				{
					model.updatetime=DateTime.Parse(row["updatetime"].ToString());
				}
				if(row["isdelete"]!=null && row["isdelete"].ToString()!="")
				{
					model.isdelete=int.Parse(row["isdelete"].ToString());
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
			strSql.Append("select opinionid,opiniontypeid,opinioncontent,updatetime,isdelete ");
			strSql.Append(" FROM dp_opinion ");
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
			strSql.Append(" opinionid,opiniontypeid,opinioncontent,updatetime,isdelete ");
			strSql.Append(" FROM dp_opinion ");
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
			strSql.Append("select count(1) FROM dp_opinion ");
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
				strSql.Append("order by T.opinionid desc");
			}
			strSql.Append(")AS Row, T.*  from dp_opinion T ");
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

