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
	/// ���м�¼
	/// </summary>
	public  class calllogController:Controller
	{
		D_calllog dcalllog = new D_calllog();
		/// <summary>
		/// ���м�¼ �б�
		/// </summary>
		public ActionResult calllogList(tb_calllog model)
		{
			int count = 0;
			ViewBag.list = dcalllog.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ���м�¼ ����
		/// </summary>
		public bool calllogSave(tb_calllog model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return dcalllog.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return dcalllog.Add(model);
		}

		/// <summary>
		/// ���м�¼ ɾ��
		/// </summary>
		public bool calllogDelete(tb_calllog model)
		{
			return dcalllog.Delete(model);
		}

		/// <summary>
		/// ���м�¼ ����
		/// </summary>
		public ActionResult calllogInfo(tb_calllog model)
		{
			model = dcalllog.GetInfo(model);
			return View(model??new tb_calllog());
		}

	}
}

