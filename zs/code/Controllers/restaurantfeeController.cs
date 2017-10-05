using System;
namespace 
{
	/// <summary>
	/// �շѱ�׼
	/// </summary>
	public  class restaurantfeeController:Controller
	{
		D_restaurantfee drestaurantfee = new D_restaurantfee();
		/// <summary>
		/// �շѱ�׼ �б�
		/// </summary>
		public ActionResult restaurantfeeList(tb_restaurantfee model)
		{
			int count = 0;
			ViewBag.list = dtb_restaurantfee.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// �շѱ�׼ ����
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
		/// �շѱ�׼ ɾ��
		/// </summary>
		public bool restaurantfeeDelete(tb_restaurantfee model)
		{
			return drestaurantfee.Delete(model);
		}

		/// <summary>
		/// �շѱ�׼ ����
		/// </summary>
		public ActionResult restaurantfeeInfo(tb_restaurantfee model)
		{
			ViewBag.Info = drestaurantfee.GetInfo(model);
			return View();
		}

	}
}

