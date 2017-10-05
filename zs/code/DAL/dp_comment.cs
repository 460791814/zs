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
	/// ���ݷ�����:dp_comment
	/// </summary>
	public partial class dp_comment
	{
		public dp_comment()
		{}
		#region  Method

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(dp_comment model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("select count(1) from dp_comment");
			strSql.Append("  where commentid=@commentid");
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
		public int Add(dp_comment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into dp_comment(");
			strSql.Append("userid,areaid,classinfoid,sex,ageround,domain,job,contents,addtime)");
			strSql.Append(" values (");
			strSql.Append("@userid,@areaid,@classinfoid,@sex,@ageround,@domain,@job,@contents,@addtime)");
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
		public bool Update(dp_comment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update dp_comment set ");
			strSql.Append(" where commentid=@commentid");
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
		public bool Delete(dp_comment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from dp_comment ");
			strSql.Append(" where commentid=@commentid" );
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
		public bool DeleteList(string commentidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from dp_comment ");
			strSql.Append(" where commentid in ("+commentidlist + ")  ");
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
		public dp_comment GetModel(int commentid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" commentid,userid,areaid,classinfoid,sex,ageround,domain,job,contents,addtime ");
			strSql.Append(" from dp_comment ");
			strSql.Append(" where commentid="+commentid+"" );
			dp_comment model=new dp_comment();
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
		public dp_comment DataRowToModel(DataRow row)
		{
			dp_comment model=new dp_comment();
			if (row != null)
			{
				if(row["commentid"]!=null && row["commentid"].ToString()!="")
				{
					model.commentid=int.Parse(row["commentid"].ToString());
				}
				if(row["userid"]!=null && row["userid"].ToString()!="")
				{
					model.userid=int.Parse(row["userid"].ToString());
				}
				if(row["areaid"]!=null && row["areaid"].ToString()!="")
				{
					model.areaid=int.Parse(row["areaid"].ToString());
				}
				if(row["classinfoid"]!=null && row["classinfoid"].ToString()!="")
				{
					model.classinfoid=int.Parse(row["classinfoid"].ToString());
				}
				if(row["sex"]!=null && row["sex"].ToString()!="")
				{
					model.sex=int.Parse(row["sex"].ToString());
				}
				if(row["ageround"]!=null && row["ageround"].ToString()!="")
				{
					model.ageround=int.Parse(row["ageround"].ToString());
				}
				if(row["domain"]!=null && row["domain"].ToString()!="")
				{
					model.domain=int.Parse(row["domain"].ToString());
				}
				if(row["job"]!=null && row["job"].ToString()!="")
				{
					model.job=int.Parse(row["job"].ToString());
				}
				if(row["contents"]!=null)
				{
					model.contents=row["contents"].ToString();
				}
				if(row["addtime"]!=null && row["addtime"].ToString()!="")
				{
					model.addtime=DateTime.Parse(row["addtime"].ToString());
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
			strSql.Append("select commentid,userid,areaid,classinfoid,sex,ageround,domain,job,contents,addtime ");
			strSql.Append(" FROM dp_comment ");
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
			strSql.Append(" commentid,userid,areaid,classinfoid,sex,ageround,domain,job,contents,addtime ");
			strSql.Append(" FROM dp_comment ");
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
			strSql.Append("select count(1) FROM dp_comment ");
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
				strSql.Append("order by T.commentid desc");
			}
			strSql.Append(")AS Row, T.*  from dp_comment T ");
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

