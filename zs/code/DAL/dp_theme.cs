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
	/// ���ݷ�����:dp_theme
	/// </summary>
	public partial class dp_theme
	{
		public dp_theme()
		{}
		#region  Method

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(dp_theme model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("select count(1) from dp_theme");
			strSql.Append("  where themeid=@themeid");
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
		public int Add(dp_theme model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into dp_theme(");
			strSql.Append("themename,IsDelete)");
			strSql.Append(" values (");
			strSql.Append("@themename,@IsDelete)");
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
		public bool Update(dp_theme model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update dp_theme set ");
			strSql.Append(" where themeid=@themeid");
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
		public bool Delete(dp_theme model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from dp_theme ");
			strSql.Append(" where themeid=@themeid" );
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
		public bool DeleteList(string themeidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from dp_theme ");
			strSql.Append(" where themeid in ("+themeidlist + ")  ");
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
		public dp_theme GetModel(int themeid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" themeid,themename,IsDelete ");
			strSql.Append(" from dp_theme ");
			strSql.Append(" where themeid="+themeid+"" );
			dp_theme model=new dp_theme();
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
		public dp_theme DataRowToModel(DataRow row)
		{
			dp_theme model=new dp_theme();
			if (row != null)
			{
				if(row["themeid"]!=null && row["themeid"].ToString()!="")
				{
					model.themeid=int.Parse(row["themeid"].ToString());
				}
				if(row["themename"]!=null)
				{
					model.themename=row["themename"].ToString();
				}
				if(row["IsDelete"]!=null && row["IsDelete"].ToString()!="")
				{
					model.IsDelete=int.Parse(row["IsDelete"].ToString());
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
			strSql.Append("select themeid,themename,IsDelete ");
			strSql.Append(" FROM dp_theme ");
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
			strSql.Append(" themeid,themename,IsDelete ");
			strSql.Append(" FROM dp_theme ");
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
			strSql.Append("select count(1) FROM dp_theme ");
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
				strSql.Append("order by T.themeid desc");
			}
			strSql.Append(")AS Row, T.*  from dp_theme T ");
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

