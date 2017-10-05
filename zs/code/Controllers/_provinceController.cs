using System;
namespace 
{
	/// <summary>
	/// 省
	/// </summary>
	public  class _provinceController:Controller
	{
		D_tb_province dtb_province = new D_tb_province();
		/// <summary>
		/// 省 列表
		/// </summary>
		public ActionResult   _provinceList(tb_province model)		{
			int count = 0;
			ViewBag.list = dtb_province.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

