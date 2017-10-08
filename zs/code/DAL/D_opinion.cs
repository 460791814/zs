using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Model;
using System.Linq;
using System.Collections.Generic;
using Dapper;
namespace DAL
{
	/// <summary>
	/// ���ݷ�����:D_opinion
	/// </summary>
	public partial class D_opinion
	{
		public D_opinion()
		{}
		#region  Method

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(tb_opinion model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("select count(1) from tb_opinion");
			strSql.Append("  where id=@id ");
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
		public bool Add(tb_opinion model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_opinion(");
			strSql.Append("id,username,content,addtime)");
			strSql.Append(" values (");
			strSql.Append("@id,@username,@content,@addtime)");
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
		public bool Update(tb_opinion model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder setSql=new StringBuilder();
			strSql.Append("update tb_opinion set ");
			if(!String.IsNullOrEmpty(model.username))
			{
				setSql.Append( "username=@username,");
			}
			if(!String.IsNullOrEmpty(model.content))
			{
				setSql.Append( "content=@content,");
			}
			if(model.addtime!=null)
			{
				setSql.Append( "addtime=@addtime,");
			}
			strSql.Append(setSql.ToString().TrimEnd(','));
			strSql.Append(" where id=@id ");
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
		public bool Delete(tb_opinion model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_opinion ");
			strSql.Append(" where id=@id " );
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
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_opinion ");
			strSql.Append(" where id in ("+idlist + ")  ");
			using (IDbConnection conn = DapperHelper.OpenConnection())
			{
				int count = conn.Execute(strSql.ToString());
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
		/// ��������б�
		/// </summary>
		public List<tb_opinion> GetList(tb_opinion model, ref int total)
		{
			List<tb_opinion> list;
			StringBuilder strSql=new StringBuilder();
			StringBuilder whereSql = new StringBuilder(" where 1 = 1 ");
			strSql.Append(" select  ROW_NUMBER() OVER(ORDER BY id desc) AS RID, * from tb_opinion ");
			if(!String.IsNullOrEmpty(model.id))
			{
				whereSql.Append( " and id=@id");
			}
			if(!String.IsNullOrEmpty(model.username))
			{
				whereSql.Append( " and username=@username");
			}
			if(!String.IsNullOrEmpty(model.content))
			{
				whereSql.Append( " and content=@content");
			}
			if(model.addtime!=null)
			{
				whereSql.Append( " and addtime=@addtime");
			}
			strSql.Append(whereSql);
			string CountSql = "SELECT COUNT(1) as RowsCount FROM (" + strSql.ToString() + ") AS CountList";
			string pageSqlStr = "select * from ( " + strSql.ToString() + " ) as Temp_PageData where Temp_PageData.RID BETWEEN {0} AND {1}";
			pageSqlStr = string.Format(pageSqlStr, (model.PageSize * (model.PageIndex - 1) + 1).ToString(), (model.PageSize * model.PageIndex).ToString());
			using (IDbConnection conn = DapperHelper.OpenConnection())
			{
				list = conn.Query <tb_opinion>(pageSqlStr, model)?.ToList();
				total = conn.ExecuteScalar<int>(CountSql, model);
			}
			return list;
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tb_opinion GetInfo(tb_opinion model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("select * from tb_opinion");
			strSql.Append("  where id=@id ");
			using (IDbConnection conn = DapperHelper.OpenConnection())
			{
				model = conn.Query <tb_opinion>(strSql.ToString(), model)?.FirstOrDefault();
			}
			return model;
		}
		#endregion  Method
	}
}

