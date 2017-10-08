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
	/// ÷‹±ﬂ≈‰Ã◊ΩÈ…‹
	/// </summary>
	public  class buildingaroundController:Controller
	{
		D_buildingaround dbuildingaround = new D_buildingaround();
		/// <summary>
		/// ÷‹±ﬂ≈‰Ã◊ΩÈ…‹ ¡–±Ì
		/// </summary>
		public ActionResult buildingaroundList(tb_buildingaround model)
		{
			int count = 0;
			ViewBag.list = dbuildingaround.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ÷‹±ﬂ≈‰Ã◊ΩÈ…‹ ±£¥Ê
		/// </summary>
		public bool buildingaroundSave(tb_buildingaround model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return dbuildingaround.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return dbuildingaround.Add(model);
		}

		/// <summary>
		/// ÷‹±ﬂ≈‰Ã◊ΩÈ…‹ …æ≥˝
		/// </summary>
		public bool buildingaroundDelete(tb_buildingaround model)
		{
			return dbuildingaround.Delete(model);
		}

		/// <summary>
		/// ÷‹±ﬂ≈‰Ã◊ΩÈ…‹ œÍ«È
		/// </summary>
		public ActionResult buildingaroundInfo(tb_buildingaround model)
		{
			model = dbuildingaround.GetInfo(model);
			return View(model??new tb_buildingaround());
		}

	}
}

