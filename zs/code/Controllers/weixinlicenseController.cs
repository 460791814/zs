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
	/// ΢��
	/// </summary>
	public  class weixinlicenseController:Controller
	{
		D_weixinlicense dweixinlicense = new D_weixinlicense();
		/// <summary>
		/// ΢�� �б�
		/// </summary>
		public ActionResult weixinlicenseList(tb_weixinlicense model)
		{
			int count = 0;
			ViewBag.list = dweixinlicense.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ΢�� ����
		/// </summary>
		public bool weixinlicenseSave(tb_weixinlicense model)
		{
			if (model == null)
			{
				return false;
			}
			return dweixinlicense.Add(model);
		}

		/// <summary>
		/// ΢�� ɾ��
		/// </summary>
		public bool weixinlicenseDelete(tb_weixinlicense model)
		{
			return dweixinlicense.Delete(model);
		}

		/// <summary>
		/// ΢�� ����
		/// </summary>
		public ActionResult weixinlicenseInfo(tb_weixinlicense model)
		{
			model = dweixinlicense.GetInfo(model);
			return View(model??new tb_weixinlicense());
		}

	}
}

