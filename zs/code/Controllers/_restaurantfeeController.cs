using System;
namespace 
{
	/// <summary>
	/// �շѱ�׼
	/// </summary>
	public  class _restaurantfeeController:Controller
	{
		D_tb_restaurantfee dtb_restaurantfee = new D_tb_restaurantfee();
		/// <summary>
		/// �շѱ�׼ �б�
		/// </summary>
		public ActionResult   _restaurantfeeList(tb_restaurantfee model)		{
			int count = 0;
			ViewBag.list = dtb_restaurantfee.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

