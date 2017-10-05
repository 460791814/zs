using System;
namespace 
{
	/// <summary>
	/// Â¥Óî
	/// </summary>
	public  class _houseController:Controller
	{
		D_tb_house dtb_house = new D_tb_house();
		/// <summary>
		/// Â¥Óî ÁÐ±í
		/// </summary>
		public ActionResult   _houseList(tb_house model)		{
			int count = 0;
			ViewBag.list = dtb_house.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

