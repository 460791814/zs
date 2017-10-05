using System;
namespace 
{
	/// <summary>
	/// 文印设计
	/// </summary>
	public  class _copyroomController:Controller
	{
		D_tb_copyroom dtb_copyroom = new D_tb_copyroom();
		/// <summary>
		/// 文印设计 列表
		/// </summary>
		public ActionResult   _copyroomList(tb_copyroom model)		{
			int count = 0;
			ViewBag.list = dtb_copyroom.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

