using System;
namespace 
{
	/// <summary>
	/// 收费标准
	/// </summary>
	public  class _restaurantfeeController:Controller
	{
		D_tb_restaurantfee dtb_restaurantfee = new D_tb_restaurantfee();
		/// <summary>
		/// 收费标准 列表
		/// </summary>
		public ActionResult   _restaurantfeeList(tb_restaurantfee model)		{
			int count = 0;
			ViewBag.list = dtb_restaurantfee.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

