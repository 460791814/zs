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
	/// ��½��־
	/// </summary>
	public  class loginlogController:Controller
	{
		D_loginlog dloginlog = new D_loginlog();
		/// <summary>
		/// ��½��־ �б�
		/// </summary>
		public ActionResult loginlogList(tb_loginlog model)
		{
			int count = 0;
			ViewBag.list = dloginlog.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ��½��־ ����
		/// </summary>
		public bool loginlogSave(tb_loginlog model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return dloginlog.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return dloginlog.Add(model);
		}

		/// <summary>
		/// ��½��־ ɾ��
		/// </summary>
		public bool loginlogDelete(tb_loginlog model)
		{
			return dloginlog.Delete(model);
		}

		/// <summary>
		/// ��½��־ ����
		/// </summary>
		public ActionResult loginlogInfo(tb_loginlog model)
		{
			model = dloginlog.GetInfo(model);
			return View(model??new tb_loginlog());
		}

	}
}

