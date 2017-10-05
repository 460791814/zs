using System;
namespace 
{
	/// <summary>
	/// 县
	/// </summary>
	public  class _countyController:Controller
	{
		D_tb_county dtb_county = new D_tb_county();
		/// <summary>
		/// 县 列表
		/// </summary>
		public ActionResult   _countyList(tb_county model)		{
			int count = 0;
			ViewBag.list = dtb_county.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

