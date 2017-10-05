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
	/// ���ݷ�����:dp_commentitem
	/// </summary>
	public partial class dp_commentitem
	{
		public dp_commentitem()
		{}
		#region  Method

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(dp_commentitem model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("select count(1) from dp_commentitem");
			strSql.Append("  where commentitemid=@commentitemid");
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
		/// ����һ������
		/// </summary>
		public int Add(dp_commentitem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into dp_commentitem(");
			strSql.Append("commenttypeid,title,isdelete)");
			strSql.Append(" values (");
			strSql.Append("@commenttypeid,@title,@isdelete)");
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
		/// ����һ������
		/// </summary>
		public bool Update(dp_commentitem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update dp_commentitem set ");
			strSql.Append(" where commentitemid=@commentitemid");
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
		/// ɾ��һ������
		/// </summary>
		public bool Delete(dp_commentitem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from dp_commentitem ");
			strSql.Append(" where commentitemid=@commentitemid" );
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
		/// ����ɾ������
		/// </summary>
		public bool DeleteList(string commentitemidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from dp_commentitem ");
			strSql.Append(" where commentitemid in ("+commentitemidlist + ")  ");
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
		/// �õ�һ������ʵ��
		/// </summary>
		public dp_commentitem GetModel(int commentitemid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" commentitemid,commenttypeid,title,isdelete ");
			strSql.Append(" from dp_commentitem ");
			strSql.Append(" where commentitemid="+commentitemid+"" );
			dp_commentitem model=new dp_commentitem();
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
		/// �õ�һ������ʵ��
		/// </summary>
		public dp_commentitem DataRowToModel(DataRow row)
		{
			dp_commentitem model=new dp_commentitem();
			if (row != null)
			{
				if(row["commentitemid"]!=null && row["commentitemid"].ToString()!="")
				{
					model.commentitemid=int.Parse(row["commentitemid"].ToString());
				}
				if(row["commenttypeid"]!=null && row["commenttypeid"].ToString()!="")
				{
					model.commenttypeid=int.Parse(row["commenttypeid"].ToString());
				}
				if(row["title"]!=null)
				{
					model.title=row["title"].ToString();
				}
				if(row["isdelete"]!=null && row["isdelete"].ToString()!="")
				{
					model.isdelete=int.Parse(row["isdelete"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select commentitemid,commenttypeid,title,isdelete ");
			strSql.Append(" FROM dp_commentitem ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return .Query(strSql.ToString());
		}

		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" commentitemid,commenttypeid,title,isdelete ");
			strSql.Append(" FROM dp_commentitem ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return .Query(strSql.ToString());
		}

		/// <summary>
		/// ��ȡ��¼����
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM dp_commentitem ");
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
		/// ��ҳ��ȡ�����б�
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
				strSql.Append("order by T.commentitemid desc");
			}
			strSql.Append(")AS Row, T.*  from dp_commentitem T ");
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

