using System;
namespace 
{
	/// <summary>
	/// ��
	/// </summary>
	public  class _cityController:Controller
	{
		D_tb_city dtb_city = new D_tb_city();
		/// <summary>
		/// �� �б�
		/// </summary>
		public ActionResult   _cityList(tb_city model)		{
			int count = 0;
			ViewBag.list = dtb_city.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

