using System;
namespace 
{
	/// <summary>
	/// 会议服务 会议预定管理
	/// </summary>
	public  class _meetingorderController:Controller
	{
		D_tb_meetingorder dtb_meetingorder = new D_tb_meetingorder();
		/// <summary>
		/// 会议服务 会议预定管理 列表
		/// </summary>
		public ActionResult   _meetingorderList(tb_meetingorder model)		{
			int count = 0;
			ViewBag.list = dtb_meetingorder.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

