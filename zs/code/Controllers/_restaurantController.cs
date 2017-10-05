using System;
namespace 
{
	/// <summary>
	/// 餐饮美食
	/// </summary>
	public  class _restaurantController:Controller
	{
		D_tb_restaurant dtb_restaurant = new D_tb_restaurant();
		/// <summary>
		/// 餐饮美食 列表
		/// </summary>
		public ActionResult   _restaurantList(tb_restaurant model)		{
			int count = 0;
			ViewBag.list = dtb_restaurant.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

