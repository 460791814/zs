using System;
namespace 
{
	/// <summary>
	/// 会议室配套设备设施
	/// </summary>
	public  class meetingroomdeviceController:Controller
	{
		D_meetingroomdevice dmeetingroomdevice = new D_meetingroomdevice();
		/// <summary>
		/// 会议室配套设备设施 列表
		/// </summary>
		public ActionResult meetingroomdeviceList(tb_meetingroomdevice model)
		{
			int count = 0;
			ViewBag.list = dtb_meetingroomdevice.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// 会议室配套设备设施 保存
		/// </summary>
		public bool meetingroomdeviceSave(tb_meetingroomdevice model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dmeetingroomdevice.Update(model);
			}
			return dmeetingroomdevice.Add(model)>0;
		}

		/// <summary>
		/// 会议室配套设备设施 删除
		/// </summary>
		public bool meetingroomdeviceDelete(tb_meetingroomdevice model)
		{
			return dmeetingroomdevice.Delete(model);
		}

		/// <summary>
		/// 会议室配套设备设施 详情
		/// </summary>
		public ActionResult meetingroomdeviceInfo(tb_meetingroomdevice model)
		{
			ViewBag.Info = dmeetingroomdevice.GetInfo(model);
			return View();
		}

	}
}

