using System;
namespace 
{
	/// <summary>
	/// 楼宇配套设备
	/// </summary>
	public  class housedeviceController:Controller
	{
		D_housedevice dhousedevice = new D_housedevice();
		/// <summary>
		/// 楼宇配套设备 列表
		/// </summary>
		public ActionResult housedeviceList(tb_housedevice model)
		{
			int count = 0;
			ViewBag.list = dtb_housedevice.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// 楼宇配套设备 保存
		/// </summary>
		public bool housedeviceSave(tb_housedevice model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dhousedevice.Update(model);
			}
			return dhousedevice.Add(model)>0;
		}

		/// <summary>
		/// 楼宇配套设备 删除
		/// </summary>
		public bool housedeviceDelete(tb_housedevice model)
		{
			return dhousedevice.Delete(model);
		}

		/// <summary>
		/// 楼宇配套设备 详情
		/// </summary>
		public ActionResult housedeviceInfo(tb_housedevice model)
		{
			ViewBag.Info = dhousedevice.GetInfo(model);
			return View();
		}

	}
}

