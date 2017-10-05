using System;
namespace 
{
	/// <summary>
	/// 楼宇配套服务
	/// </summary>
	public  class houseserviceController:Controller
	{
		D_houseservice dhouseservice = new D_houseservice();
		/// <summary>
		/// 楼宇配套服务 列表
		/// </summary>
		public ActionResult houseserviceList(tb_houseservice model)
		{
			int count = 0;
			ViewBag.list = dtb_houseservice.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// 楼宇配套服务 保存
		/// </summary>
		public bool houseserviceSave(tb_houseservice model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dhouseservice.Update(model);
			}
			return dhouseservice.Add(model)>0;
		}

		/// <summary>
		/// 楼宇配套服务 删除
		/// </summary>
		public bool houseserviceDelete(tb_houseservice model)
		{
			return dhouseservice.Delete(model);
		}

		/// <summary>
		/// 楼宇配套服务 详情
		/// </summary>
		public ActionResult houseserviceInfo(tb_houseservice model)
		{
			ViewBag.Info = dhouseservice.GetInfo(model);
			return View();
		}

	}
}

