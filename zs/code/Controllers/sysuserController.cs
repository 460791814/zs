using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using Model;
using Comp;
namespace cnooc.property.manage.Controllers
{
	/// <summary>
	/// ϵͳ�û�
	/// </summary>
	public  class sysuserController:Controller
	{
		D_sysuser dsysuser = new D_sysuser();
		/// <summary>
		/// ϵͳ�û� �б�
		/// </summary>
		public ActionResult sysuserList(tb_sysuser model)
		{
			int count = 0;
			ViewBag.list = dsysuser.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ϵͳ�û� ����
		/// </summary>
		public bool sysuserSave(tb_sysuser model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return dsysuser.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return dsysuser.Add(model);
		}

		/// <summary>
		/// ϵͳ�û� ɾ��
		/// </summary>
		public bool sysuserDelete(tb_sysuser model)
		{
			return dsysuser.Delete(model);
		}

		/// <summary>
		/// ϵͳ�û� ����
		/// </summary>
		public ActionResult sysuserInfo(tb_sysuser model)
		{
			model = dsysuser.GetInfo(model);
			return View(model??new tb_sysuser());
		}

	}
}

