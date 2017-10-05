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
	/// 数据访问类:dp_food
	/// </summary>
	public partial class dp_food
	{
		public dp_food()
		{}
		#region  Method

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(dp_food model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("select count(1) from dp_food");
			strSql.Append("  where foodid=@foodid");
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
		public int Add(dp_food model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into dp_food(");
			strSql.Append("areaid,classinfoid,dishid,foodname,pid,pname,pic,praise,bad,isdisplay,updatetime,addtime)");
			strSql.Append(" values (");
			strSql.Append("@areaid,@classinfoid,@dishid,@foodname,@pid,@pname,@pic,@praise,@bad,@isdisplay,@updatetime,@addtime)");
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
		public bool Update(dp_food model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update dp_food set ");
			strSql.Append(" where foodid=@foodid");
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
		public bool Delete(dp_food model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from dp_food ");
			strSql.Append(" where foodid=@foodid" );
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
		public bool DeleteList(string foodidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from dp_food ");
			strSql.Append(" where foodid in ("+foodidlist + ")  ");
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
		public dp_food GetModel(int foodid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" foodid,areaid,classinfoid,dishid,foodname,pid,pname,pic,praise,bad,isdisplay,updatetime,addtime ");
			strSql.Append(" from dp_food ");
			strSql.Append(" where foodid="+foodid+"" );
			dp_food model=new dp_food();
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
		public dp_food DataRowToModel(DataRow row)
		{
			dp_food model=new dp_food();
			if (row != null)
			{
				if(row["foodid"]!=null && row["foodid"].ToString()!="")
				{
					model.foodid=int.Parse(row["foodid"].ToString());
				}
				if(row["areaid"]!=null && row["areaid"].ToString()!="")
				{
					model.areaid=int.Parse(row["areaid"].ToString());
				}
				if(row["classinfoid"]!=null && row["classinfoid"].ToString()!="")
				{
					model.classinfoid=int.Parse(row["classinfoid"].ToString());
				}
				if(row["dishid"]!=null && row["dishid"].ToString()!="")
				{
					model.dishid=int.Parse(row["dishid"].ToString());
				}
				if(row["foodname"]!=null)
				{
					model.foodname=row["foodname"].ToString();
				}
				if(row["pid"]!=null && row["pid"].ToString()!="")
				{
					model.pid=int.Parse(row["pid"].ToString());
				}
				if(row["pname"]!=null)
				{
					model.pname=row["pname"].ToString();
				}
				if(row["pic"]!=null)
				{
					model.pic=row["pic"].ToString();
				}
				if(row["praise"]!=null && row["praise"].ToString()!="")
				{
					model.praise=int.Parse(row["praise"].ToString());
				}
				if(row["bad"]!=null && row["bad"].ToString()!="")
				{
					model.bad=int.Parse(row["bad"].ToString());
				}
				if(row["isdisplay"]!=null && row["isdisplay"].ToString()!="")
				{
					model.isdisplay=int.Parse(row["isdisplay"].ToString());
				}
				if(row["updatetime"]!=null && row["updatetime"].ToString()!="")
				{
					model.updatetime=DateTime.Parse(row["updatetime"].ToString());
				}
				if(row["addtime"]!=null && row["addtime"].ToString()!="")
				{
					model.addtime=DateTime.Parse(row["addtime"].ToString());
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
			strSql.Append("select foodid,areaid,classinfoid,dishid,foodname,pid,pname,pic,praise,bad,isdisplay,updatetime,addtime ");
			strSql.Append(" FROM dp_food ");
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
			strSql.Append(" foodid,areaid,classinfoid,dishid,foodname,pid,pname,pic,praise,bad,isdisplay,updatetime,addtime ");
			strSql.Append(" FROM dp_food ");
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
			strSql.Append("select count(1) FROM dp_food ");
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
				strSql.Append("order by T.foodid desc");
			}
			strSql.Append(")AS Row, T.*  from dp_food T ");
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

