using System;
namespace 
{
	/// <summary>
	/// 会议室评价
	/// </summary>
	public  class _meetingroomcommentController:Controller
	{
		D_tb_meetingroomcomment dtb_meetingroomcomment = new D_tb_meetingroomcomment();
		/// <summary>
		/// 会议室评价 列表
		/// </summary>
		public ActionResult   _meetingroomcommentList(tb_meetingroomcomment model)		{
			int count = 0;
			ViewBag.list = dtb_meetingroomcomment.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

