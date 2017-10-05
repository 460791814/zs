using System;
namespace 
{
	/// <summary>
	/// 各类车型车位数量
	/// </summary>
	public  class _parkspaceController:Controller
	{
		D_tb_parkspace dtb_parkspace = new D_tb_parkspace();
		/// <summary>
		/// 各类车型车位数量 列表
		/// </summary>
		public ActionResult   _parkspaceList(tb_parkspace model)		{
			int count = 0;
			ViewBag.list = dtb_parkspace.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

