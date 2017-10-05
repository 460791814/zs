using System;
namespace 
{
	/// <summary>
	/// 意见反馈
	/// </summary>
	public  class _opinionController:Controller
	{
		D_tb_opinion dtb_opinion = new D_tb_opinion();
		/// <summary>
		/// 意见反馈 列表
		/// </summary>
		public ActionResult   _opinionList(tb_opinion model)		{
			int count = 0;
			ViewBag.list = dtb_opinion.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

