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
	/// qq
	/// </summary>
	public  class qqlicenseController:Controller
	{
		D_qqlicense dqqlicense = new D_qqlicense();
		/// <summary>
		/// qq �б�
		/// </summary>
		public ActionResult qqlicenseList(tb_qqlicense model)
		{
			int count = 0;
			ViewBag.list = dqqlicense.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// qq ����
		/// </summary>
		public bool qqlicenseSave(tb_qqlicense model)
		{
			if (model == null)
			{
				return false;
			}
			return dqqlicense.Add(model);
		}

		/// <summary>
		/// qq ɾ��
		/// </summary>
		public bool qqlicenseDelete(tb_qqlicense model)
		{
			return dqqlicense.Delete(model);
		}

		/// <summary>
		/// qq ����
		/// </summary>
		public ActionResult qqlicenseInfo(tb_qqlicense model)
		{
			model = dqqlicense.GetInfo(model);
			return View(model??new tb_qqlicense());
		}

	}
}

