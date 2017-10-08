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
	/// ������־
	/// </summary>
	public  class operationlogController:Controller
	{
		D_operationlog doperationlog = new D_operationlog();
		/// <summary>
		/// ������־ �б�
		/// </summary>
		public ActionResult operationlogList(tb_operationlog model)
		{
			int count = 0;
			ViewBag.list = doperationlog.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ������־ ����
		/// </summary>
		public bool operationlogSave(tb_operationlog model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return doperationlog.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return doperationlog.Add(model);
		}

		/// <summary>
		/// ������־ ɾ��
		/// </summary>
		public bool operationlogDelete(tb_operationlog model)
		{
			return doperationlog.Delete(model);
		}

		/// <summary>
		/// ������־ ����
		/// </summary>
		public ActionResult operationlogInfo(tb_operationlog model)
		{
			model = doperationlog.GetInfo(model);
			return View(model??new tb_operationlog());
		}

	}
}

