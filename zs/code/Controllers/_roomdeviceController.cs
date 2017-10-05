using System;
namespace 
{
	/// <summary>
	/// 其他配套设备设施
	/// </summary>
	public  class _roomdeviceController:Controller
	{
		D_tb_roomdevice dtb_roomdevice = new D_tb_roomdevice();
		/// <summary>
		/// 其他配套设备设施 列表
		/// </summary>
		public ActionResult   _roomdeviceList(tb_roomdevice model)		{
			int count = 0;
			ViewBag.list = dtb_roomdevice.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

