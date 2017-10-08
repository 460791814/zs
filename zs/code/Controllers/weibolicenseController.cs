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
	/// Î¢²©
	/// </summary>
	public  class weibolicenseController:Controller
	{
		D_weibolicense dweibolicense = new D_weibolicense();
		/// <summary>
		/// Î¢²© ÁÐ±í
		/// </summary>
		public ActionResult weibolicenseList(tb_weibolicense model)
		{
			int count = 0;
			ViewBag.list = dweibolicense.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// Î¢²© ±£´æ
		/// </summary>
		public bool weibolicenseSave(tb_weibolicense model)
		{
			if (model == null)
			{
				return false;
			}
			return dweibolicense.Add(model);
		}

		/// <summary>
		/// Î¢²© É¾³ý
		/// </summary>
		public bool weibolicenseDelete(tb_weibolicense model)
		{
			return dweibolicense.Delete(model);
		}

		/// <summary>
		/// Î¢²© ÏêÇé
		/// </summary>
		public ActionResult weibolicenseInfo(tb_weibolicense model)
		{
			model = dweibolicense.GetInfo(model);
			return View(model??new tb_weibolicense());
		}

	}
}

