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
	/// ���ݷ�����:D_sms
	/// </summary>
	public partial class D_sms
	{
		public D_sms()
		{}
		#region  Method

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(tb_sms model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("select count(1) from tb_sms");
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
		public bool Add(tb_sms model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_sms(");
			strSql.Append("id,phonenum,verificationcode,senddate,sendtype)");
			strSql.Append(" values (");
			strSql.Append("@id,@phonenum,@verificationcode,@senddate,@sendtype)");
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
		public bool Update(tb_sms model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder setSql=new StringBuilder();
			strSql.Append("update tb_sms set ");
			if(!String.IsNullOrEmpty(model.phonenum))
			{
				setSql.Append( "phonenum=@phonenum");
			}
			if(!String.IsNullOrEmpty(model.verificationcode))
			{
				setSql.Append( "verificationcode=@verificationcode");
			}
			if(model.senddate!=null)
			{
				setSql.Append( "senddate=@senddate");
			}
			if(model.sendtype!=null)
			{
				setSql.Append( "sendtype=@sendtype");
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
		public bool Delete(tb_sms model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_sms ");
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
			strSql.Append("delete from tb_sms ");
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
		public List<tb_sms> GetList(tb_sms model, ref int total)
		{
			List<tb_sms> list;
			StringBuilder strSql=new StringBuilder();
			StringBuilder whereSql = new StringBuilder(" where 1 = 1 ");
			strSql.Append(" select  ROW_NUMBER() OVER(ORDER BY id desc) AS RID, * from tb_sms ");
			if(!String.IsNullOrEmpty(model.id))
			{
				whereSql.Append( " and id=@id");
			}
			if(!String.IsNullOrEmpty(model.phonenum))
			{
				whereSql.Append( " and phonenum=@phonenum");
			}
			if(!String.IsNullOrEmpty(model.verificationcode))
			{
				whereSql.Append( " and verificationcode=@verificationcode");
			}
			if(model.senddate!=null)
			{
				whereSql.Append( " and senddate=@senddate");
			}
			if(model.sendtype!=null)
			{
				whereSql.Append( " and sendtype=@sendtype");
			}
			strSql.Append(whereSql);
			string CountSql = "SELECT COUNT(1) as RowsCount FROM (" + strSql.ToString() + ") AS CountList";
			string pageSqlStr = "select * from ( " + strSql.ToString() + " ) as Temp_PageData where Temp_PageData.RID BETWEEN {0} AND {1}";
			pageSqlStr = string.Format(pageSqlStr, (model.PageSize * (model.PageIndex - 1) + 1).ToString(), (model.PageSize * model.PageIndex).ToString());
			using (IDbConnection conn = DapperHelper.OpenConnection())
			{
				list = conn.Query <tb_sms>(pageSqlStr, model)?.ToList();
				total = conn.ExecuteScalar<int>(CountSql, model);
			}
			return list;
		}

		#endregion  Method
	}
}
