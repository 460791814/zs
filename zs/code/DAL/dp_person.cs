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
	/// 数据访问类:dp_person
	/// </summary>
	public partial class dp_person
	{
		public dp_person()
		{}
		#region  Method

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(dp_person model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("select count(1) from dp_person");
			strSql.Append("  where personid=@personid");
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
		public int Add(dp_person model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into dp_person(");
			strSql.Append("areaid,classinfoid,personname,jobtypeid,perfect,good,bad,isdelete)");
			strSql.Append(" values (");
			strSql.Append("@areaid,@classinfoid,@personname,@jobtypeid,@perfect,@good,@bad,@isdelete)");
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
		public bool Update(dp_person model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update dp_person set ");
			strSql.Append(" where personid=@personid");
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
		public bool Delete(dp_person model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from dp_person ");
			strSql.Append(" where personid=@personid" );
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
		public bool DeleteList(string personidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from dp_person ");
			strSql.Append(" where personid in ("+personidlist + ")  ");
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
		public dp_person GetModel(int personid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" personid,areaid,classinfoid,personname,jobtypeid,perfect,good,bad,isdelete ");
			strSql.Append(" from dp_person ");
			strSql.Append(" where personid="+personid+"" );
			dp_person model=new dp_person();
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
		public dp_person DataRowToModel(DataRow row)
		{
			dp_person model=new dp_person();
			if (row != null)
			{
				if(row["personid"]!=null && row["personid"].ToString()!="")
				{
					model.personid=int.Parse(row["personid"].ToString());
				}
				if(row["areaid"]!=null && row["areaid"].ToString()!="")
				{
					model.areaid=int.Parse(row["areaid"].ToString());
				}
				if(row["classinfoid"]!=null && row["classinfoid"].ToString()!="")
				{
					model.classinfoid=int.Parse(row["classinfoid"].ToString());
				}
				if(row["personname"]!=null)
				{
					model.personname=row["personname"].ToString();
				}
				if(row["jobtypeid"]!=null && row["jobtypeid"].ToString()!="")
				{
					model.jobtypeid=int.Parse(row["jobtypeid"].ToString());
				}
				if(row["perfect"]!=null && row["perfect"].ToString()!="")
				{
					model.perfect=int.Parse(row["perfect"].ToString());
				}
				if(row["good"]!=null && row["good"].ToString()!="")
				{
					model.good=int.Parse(row["good"].ToString());
				}
				if(row["bad"]!=null && row["bad"].ToString()!="")
				{
					model.bad=int.Parse(row["bad"].ToString());
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
			strSql.Append("select personid,areaid,classinfoid,personname,jobtypeid,perfect,good,bad,isdelete ");
			strSql.Append(" FROM dp_person ");
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
			strSql.Append(" personid,areaid,classinfoid,personname,jobtypeid,perfect,good,bad,isdelete ");
			strSql.Append(" FROM dp_person ");
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
			strSql.Append("select count(1) FROM dp_person ");
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
				strSql.Append("order by T.personid desc");
			}
			strSql.Append(")AS Row, T.*  from dp_person T ");
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

