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
	/// ���ݷ�����:D_roomdevice
	/// </summary>
	public partial class D_roomdevice
	{
		public D_roomdevice()
		{}
		#region  Method

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(tb_roomdevice model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("select count(1) from tb_roomdevice");
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
		public bool Add(tb_roomdevice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_roomdevice(");
			strSql.Append("id,roomid,name,intro,addtime)");
			strSql.Append(" values (");
			strSql.Append("@id,@roomid,@name,@intro,@addtime)");
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
		public bool Update(tb_roomdevice model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder setSql=new StringBuilder();
			strSql.Append("update tb_roomdevice set ");
			if(model.roomid!=null)
			{
				setSql.Append( "roomid=@roomid");
			}
			if(!String.IsNullOrEmpty(model.name))
			{
				setSql.Append( "name=@name");
			}
			if(!String.IsNullOrEmpty(model.intro))
			{
				setSql.Append( "intro=@intro");
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
		public bool Delete(tb_roomdevice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_roomdevice ");
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
			strSql.Append("delete from tb_roomdevice ");
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
		public List<tb_roomdevice> GetList(tb_roomdevice model, ref int total)
		{
			List<tb_roomdevice> list;
			StringBuilder strSql=new StringBuilder();
			StringBuilder whereSql = new StringBuilder(" where 1 = 1 ");
			strSql.Append(" select  ROW_NUMBER() OVER(ORDER BY id desc) AS RID, * from tb_roomdevice ");
			if(!String.IsNullOrEmpty(model.id))
			{
				whereSql.Append( " and id=@id");
			}
			if(model.roomid!=null)
			{
				whereSql.Append( " and roomid=@roomid");
			}
			if(!String.IsNullOrEmpty(model.name))
			{
				whereSql.Append( " and name=@name");
			}
			if(!String.IsNullOrEmpty(model.intro))
			{
				whereSql.Append( " and intro=@intro");
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
				list = conn.Query <tb_roomdevice>(pageSqlStr, model)?.ToList();
				total = conn.ExecuteScalar<int>(CountSql, model);
			}
			return list;
		}

		#endregion  Method
	}
}
