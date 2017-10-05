using System;
namespace 
{
	/// <summary>
	/// 收费标准
	/// </summary>
	public  class restaurantfeeController:Controller
	{
		D_restaurantfee drestaurantfee = new D_restaurantfee();
		/// <summary>
		/// 收费标准 列表
		/// </summary>
		public ActionResult restaurantfeeList(tb_restaurantfee model)
		{
			int count = 0;
			ViewBag.list = dtb_restaurantfee.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// 收费标准 保存
		/// </summary>
		public bool restaurantfeeSave(tb_restaurantfee model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return drestaurantfee.Update(model);
			}
			return drestaurantfee.Add(model)>0;
		}

		/// <summary>
		/// 收费标准 删除
		/// </summary>
		public bool restaurantfeeDelete(tb_restaurantfee model)
		{
			return drestaurantfee.Delete(model);
		}

		/// <summary>
		/// 收费标准 详情
		/// </summary>
		public ActionResult restaurantfeeInfo(tb_restaurantfee model)
		{
			ViewBag.Info = drestaurantfee.GetInfo(model);
			return View();
		}

	}
}

