using System;
namespace 
{
	/// <summary>
	/// 会议室管理
	/// </summary>
	public  class _meetingroomController:Controller
	{
		D_tb_meetingroom dtb_meetingroom = new D_tb_meetingroom();
		/// <summary>
		/// 会议室管理 列表
		/// </summary>
		public ActionResult   _meetingroomList(tb_meetingroom model)		{
			int count = 0;
			ViewBag.list = dtb_meetingroom.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

