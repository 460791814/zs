using System;
namespace 
{
	/// <summary>
	/// 车位信息
	/// </summary>
	public  class _parkController:Controller
	{
		D_tb_park dtb_park = new D_tb_park();
		/// <summary>
		/// 车位信息 列表
		/// </summary>
		public ActionResult   _parkList(tb_park model)		{
			int count = 0;
			ViewBag.list = dtb_park.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

