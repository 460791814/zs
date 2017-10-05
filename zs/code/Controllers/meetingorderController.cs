using System;
namespace 
{
	/// <summary>
	/// 会议服务 会议预定管理
	/// </summary>
	public  class meetingorderController:Controller
	{
		D_meetingorder dmeetingorder = new D_meetingorder();
		/// <summary>
		/// 会议服务 会议预定管理 列表
		/// </summary>
		public ActionResult meetingorderList(tb_meetingorder model)
		{
			int count = 0;
			ViewBag.list = dtb_meetingorder.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// 会议服务 会议预定管理 保存
		/// </summary>
		public bool meetingorderSave(tb_meetingorder model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dmeetingorder.Update(model);
			}
			return dmeetingorder.Add(model)>0;
		}

		/// <summary>
		/// 会议服务 会议预定管理 删除
		/// </summary>
		public bool meetingorderDelete(tb_meetingorder model)
		{
			return dmeetingorder.Delete(model);
		}

		/// <summary>
		/// 会议服务 会议预定管理 详情
		/// </summary>
		public ActionResult meetingorderInfo(tb_meetingorder model)
		{
			ViewBag.Info = dmeetingorder.GetInfo(model);
			return View();
		}

	}
}

