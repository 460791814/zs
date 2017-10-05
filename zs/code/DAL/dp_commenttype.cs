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
	/// ���ݷ�����:dp_commenttype
	/// </summary>
	public partial class dp_commenttype
	{
		public dp_commenttype()
		{}
		#region  Method

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(dp_commenttype model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("select count(1) from dp_commenttype");
			strSql.Append("  where commenttypeid=@commenttypeid");
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
		public int Add(dp_commenttype model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into dp_commenttype(");
			strSql.Append("typename,isdelete)");
			strSql.Append(" values (");
			strSql.Append("@typename,@isdelete)");
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
		public bool Update(dp_commenttype model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update dp_commenttype set ");
			strSql.Append(" where commenttypeid=@commenttypeid");
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
		public bool Delete(dp_commenttype model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from dp_commenttype ");
			strSql.Append(" where commenttypeid=@commenttypeid" );
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
		public bool DeleteList(string commenttypeidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from dp_commenttype ");
			strSql.Append(" where commenttypeid in ("+commenttypeidlist + ")  ");
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
		public dp_commenttype GetModel(int commenttypeid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" commenttypeid,typename,isdelete ");
			strSql.Append(" from dp_commenttype ");
			strSql.Append(" where commenttypeid="+commenttypeid+"" );
			dp_commenttype model=new dp_commenttype();
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
		public dp_commenttype DataRowToModel(DataRow row)
		{
			dp_commenttype model=new dp_commenttype();
			if (row != null)
			{
				if(row["commenttypeid"]!=null && row["commenttypeid"].ToString()!="")
				{
					model.commenttypeid=int.Parse(row["commenttypeid"].ToString());
				}
				if(row["typename"]!=null)
				{
					model.typename=row["typename"].ToString();
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
			strSql.Append("select commenttypeid,typename,isdelete ");
			strSql.Append(" FROM dp_commenttype ");
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
			strSql.Append(" commenttypeid,typename,isdelete ");
			strSql.Append(" FROM dp_commenttype ");
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
			strSql.Append("select count(1) FROM dp_commenttype ");
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
				strSql.Append("order by T.commenttypeid desc");
			}
			strSql.Append(")AS Row, T.*  from dp_commenttype T ");
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

