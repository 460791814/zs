using System;
namespace 
{
	/// <summary>
	/// 其他配套设备设施
	/// </summary>
	public  class roomdeviceController:Controller
	{
		D_roomdevice droomdevice = new D_roomdevice();
		/// <summary>
		/// 其他配套设备设施 列表
		/// </summary>
		public ActionResult roomdeviceList(tb_roomdevice model)
		{
			int count = 0;
			ViewBag.list = dtb_roomdevice.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// 其他配套设备设施 保存
		/// </summary>
		public bool roomdeviceSave(tb_roomdevice model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return droomdevice.Update(model);
			}
			return droomdevice.Add(model)>0;
		}

		/// <summary>
		/// 其他配套设备设施 删除
		/// </summary>
		public bool roomdeviceDelete(tb_roomdevice model)
		{
			return droomdevice.Delete(model);
		}

		/// <summary>
		/// 其他配套设备设施 详情
		/// </summary>
		public ActionResult roomdeviceInfo(tb_roomdevice model)
		{
			ViewBag.Info = droomdevice.GetInfo(model);
			return View();
		}

	}
}

