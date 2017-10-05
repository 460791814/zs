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
	/// ���ݷ�����:dp_themecommentitem
	/// </summary>
	public partial class dp_themecommentitem
	{
		public dp_themecommentitem()
		{}
		#region  Method

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(dp_themecommentitem model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("select count(1) from dp_themecommentitem");
			strSql.Append("  where themeid=@themeid and commentitemid=@commentitemid ");
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
		public bool Add(dp_themecommentitem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into dp_themecommentitem(");
			strSql.Append("themeid,commentitemid)");
			strSql.Append(" values (");
			strSql.Append("@themeid,@commentitemid)");
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
		public bool Update(dp_themecommentitem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update dp_themecommentitem set ");
			strSql.Append(" where themeid=@themeid and commentitemid=@commentitemid ");
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
		public bool Delete(dp_themecommentitem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from dp_themecommentitem ");
			strSql.Append(" where themeid=@themeid and commentitemid=@commentitemid " );
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
		/// �õ�һ������ʵ��
		/// </summary>
		public dp_themecommentitem GetModel(int themeid,int commentitemid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" themeid,commentitemid ");
			strSql.Append(" from dp_themecommentitem ");
			strSql.Append(" where themeid="+themeid+" and commentitemid="+commentitemid+" " );
			dp_themecommentitem model=new dp_themecommentitem();
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
		public dp_themecommentitem DataRowToModel(DataRow row)
		{
			dp_themecommentitem model=new dp_themecommentitem();
			if (row != null)
			{
				if(row["themeid"]!=null && row["themeid"].ToString()!="")
				{
					model.themeid=int.Parse(row["themeid"].ToString());
				}
				if(row["commentitemid"]!=null && row["commentitemid"].ToString()!="")
				{
					model.commentitemid=int.Parse(row["commentitemid"].ToString());
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
			strSql.Append("select themeid,commentitemid ");
			strSql.Append(" FROM dp_themecommentitem ");
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
			strSql.Append(" themeid,commentitemid ");
			strSql.Append(" FROM dp_themecommentitem ");
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
			strSql.Append("select count(1) FROM dp_themecommentitem ");
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
			strSql.Append(")AS Row, T.*  from dp_themecommentitem T ");
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

