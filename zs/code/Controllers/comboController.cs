using System;
namespace 
{
	/// <summary>
	/// Ì×²Í
	/// </summary>
	public  class comboController:Controller
	{
		D_combo dcombo = new D_combo();
		/// <summary>
		/// Ì×²Í ÁÐ±í
		/// </summary>
		public ActionResult comboList(tb_combo model)
		{
			int count = 0;
			ViewBag.list = dtb_combo.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// Ì×²Í ±£´æ
		/// </summary>
		public bool comboSave(tb_combo model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dcombo.Update(model);
			}
			return dcombo.Add(model)>0;
		}

		/// <summary>
		/// Ì×²Í É¾³ý
		/// </summary>
		public bool comboDelete(tb_combo model)
		{
			return dcombo.Delete(model);
		}

		/// <summary>
		/// Ì×²Í ÏêÇé
		/// </summary>
		public ActionResult comboInfo(tb_combo model)
		{
			ViewBag.Info = dcombo.GetInfo(model);
			return View();
		}

	}
}

