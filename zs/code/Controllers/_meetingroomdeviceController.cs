using System;
namespace 
{
	/// <summary>
	/// 会议室配套设备设施
	/// </summary>
	public  class _meetingroomdeviceController:Controller
	{
		D_tb_meetingroomdevice dtb_meetingroomdevice = new D_tb_meetingroomdevice();
		/// <summary>
		/// 会议室配套设备设施 列表
		/// </summary>
		public ActionResult   _meetingroomdeviceList(tb_meetingroomdevice model)		{
			int count = 0;
			ViewBag.list = dtb_meetingroomdevice.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

