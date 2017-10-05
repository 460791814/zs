using System;
namespace 
{
	/// <summary>
	/// 餐饮美食
	/// </summary>
	public  class restaurantController:Controller
	{
		D_restaurant drestaurant = new D_restaurant();
		/// <summary>
		/// 餐饮美食 列表
		/// </summary>
		public ActionResult restaurantList(tb_restaurant model)
		{
			int count = 0;
			ViewBag.list = dtb_restaurant.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// 餐饮美食 保存
		/// </summary>
		public bool restaurantSave(tb_restaurant model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return drestaurant.Update(model);
			}
			return drestaurant.Add(model)>0;
		}

		/// <summary>
		/// 餐饮美食 删除
		/// </summary>
		public bool restaurantDelete(tb_restaurant model)
		{
			return drestaurant.Delete(model);
		}

		/// <summary>
		/// 餐饮美食 详情
		/// </summary>
		public ActionResult restaurantInfo(tb_restaurant model)
		{
			ViewBag.Info = drestaurant.GetInfo(model);
			return View();
		}

	}
}

