using System;
namespace 
{
	/// <summary>
	/// Â¥Óî
	/// </summary>
	public  class houseController:Controller
	{
		D_house dhouse = new D_house();
		/// <summary>
		/// Â¥Óî ÁÐ±í
		/// </summary>
		public ActionResult houseList(tb_house model)
		{
			int count = 0;
			ViewBag.list = dtb_house.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// Â¥Óî ±£´æ
		/// </summary>
		public bool houseSave(tb_house model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dhouse.Update(model);
			}
			return dhouse.Add(model)>0;
		}

		/// <summary>
		/// Â¥Óî É¾³ý
		/// </summary>
		public bool houseDelete(tb_house model)
		{
			return dhouse.Delete(model);
		}

		/// <summary>
		/// Â¥Óî ÏêÇé
		/// </summary>
		public ActionResult houseInfo(tb_house model)
		{
			ViewBag.Info = dhouse.GetInfo(model);
			return View();
		}

	}
}

