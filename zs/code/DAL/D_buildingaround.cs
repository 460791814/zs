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
	/// ���ݷ�����:D_buildingaround
	/// </summary>
	public partial class D_buildingaround
	{
		public D_buildingaround()
		{}
		#region  Method

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(tb_buildingaround model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("select count(1) from tb_buildingaround");
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
		public bool Add(tb_buildingaround model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_buildingaround(");
			strSql.Append("id,buildingid,name,intro,addtime)");
			strSql.Append(" values (");
			strSql.Append("@id,@buildingid,@name,@intro,@addtime)");
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
		public bool Update(tb_buildingaround model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder setSql=new StringBuilder();
			strSql.Append("update tb_buildingaround set ");
			if(!String.IsNullOrEmpty(model.buildingid))
			{
				setSql.Append( "buildingid=@buildingid,");
			}
			if(!String.IsNullOrEmpty(model.name))
			{
				setSql.Append( "name=@name,");
			}
			if(!String.IsNullOrEmpty(model.intro))
			{
				setSql.Append( "intro=@intro,");
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
		public bool Delete(tb_buildingaround model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_buildingaround ");
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
			strSql.Append("delete from tb_buildingaround ");
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
		public List<tb_buildingaround> GetList(tb_buildingaround model, ref int total)
		{
			List<tb_buildingaround> list;
			StringBuilder strSql=new StringBuilder();
			StringBuilder whereSql = new StringBuilder(" where 1 = 1 ");
			strSql.Append(" select  ROW_NUMBER() OVER(ORDER BY id desc) AS RID, * from tb_buildingaround ");
			if(!String.IsNullOrEmpty(model.id))
			{
				whereSql.Append( " and id=@id");
			}
			if(!String.IsNullOrEmpty(model.buildingid))
			{
				whereSql.Append( " and buildingid=@buildingid");
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
				list = conn.Query <tb_buildingaround>(pageSqlStr, model)?.ToList();
				total = conn.ExecuteScalar<int>(CountSql, model);
			}
			return list;
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tb_buildingaround GetInfo(tb_buildingaround model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("select * from tb_buildingaround");
			strSql.Append("  where id=@id ");
			using (IDbConnection conn = DapperHelper.OpenConnection())
			{
				model = conn.Query <tb_buildingaround>(strSql.ToString(), model)?.FirstOrDefault();
			}
			return model;
		}
		#endregion  Method
	}
}

