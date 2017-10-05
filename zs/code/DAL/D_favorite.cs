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
	/// ���ݷ�����:D_favorite
	/// </summary>
	public partial class D_favorite
	{
		public D_favorite()
		{}
		#region  Method

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(tb_favorite model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("select count(1) from tb_favorite");
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
		public bool Add(tb_favorite model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_favorite(");
			strSql.Append("id,favoritetype,favoriteid,favoritedate,isdel,favoriteintro,addtime)");
			strSql.Append(" values (");
			strSql.Append("@id,@favoritetype,@favoriteid,@favoritedate,@isdel,@favoriteintro,@addtime)");
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
		public bool Update(tb_favorite model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder setSql=new StringBuilder();
			strSql.Append("update tb_favorite set ");
			if(!String.IsNullOrEmpty(model.favoritetype))
			{
				setSql.Append( "favoritetype=@favoritetype");
			}
			if(!String.IsNullOrEmpty(model.favoriteid))
			{
				setSql.Append( "favoriteid=@favoriteid");
			}
			if(model.favoritedate!=null)
			{
				setSql.Append( "favoritedate=@favoritedate");
			}
			if(model.isdel)
			{
				setSql.Append( "isdel=@isdel");
			}
			if(!String.IsNullOrEmpty(model.favoriteintro))
			{
				setSql.Append( "favoriteintro=@favoriteintro");
			}
			if(model.addtime!=null)
			{
				setSql.Append( "addtime=@addtime");
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
		public bool Delete(tb_favorite model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_favorite ");
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
			strSql.Append("delete from tb_favorite ");
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
		public List<tb_favorite> GetList(tb_favorite model, ref int total)
		{
			List<tb_favorite> list;
			StringBuilder strSql=new StringBuilder();
			StringBuilder whereSql = new StringBuilder(" where 1 = 1 ");
			strSql.Append(" select  ROW_NUMBER() OVER(ORDER BY id desc) AS RID, * from tb_favorite ");
			if(!String.IsNullOrEmpty(model.id))
			{
				whereSql.Append( " and id=@id");
			}
			if(!String.IsNullOrEmpty(model.favoritetype))
			{
				whereSql.Append( " and favoritetype=@favoritetype");
			}
			if(!String.IsNullOrEmpty(model.favoriteid))
			{
				whereSql.Append( " and favoriteid=@favoriteid");
			}
			if(model.favoritedate!=null)
			{
				whereSql.Append( " and favoritedate=@favoritedate");
			}
			if(model.isdel)
			{
				whereSql.Append( " and isdel=@isdel");
			}
			if(!String.IsNullOrEmpty(model.favoriteintro))
			{
				whereSql.Append( " and favoriteintro=@favoriteintro");
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
				list = conn.Query <tb_favorite>(pageSqlStr, model)?.ToList();
				total = conn.ExecuteScalar<int>(CountSql, model);
			}
			return list;
		}

		#endregion  Method
	}
}
