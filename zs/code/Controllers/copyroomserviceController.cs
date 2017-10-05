using System;
namespace 
{
	/// <summary>
	/// 服务类别
	/// </summary>
	public  class copyroomserviceController:Controller
	{
		D_copyroomservice dcopyroomservice = new D_copyroomservice();
		/// <summary>
		/// 服务类别 列表
		/// </summary>
		public ActionResult copyroomserviceList(tb_copyroomservice model)
		{
			int count = 0;
			ViewBag.list = dtb_copyroomservice.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// 服务类别 保存
		/// </summary>
		public bool copyroomserviceSave(tb_copyroomservice model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dcopyroomservice.Update(model);
			}
			return dcopyroomservice.Add(model)>0;
		}

		/// <summary>
		/// 服务类别 删除
		/// </summary>
		public bool copyroomserviceDelete(tb_copyroomservice model)
		{
			return dcopyroomservice.Delete(model);
		}

		/// <summary>
		/// 服务类别 详情
		/// </summary>
		public ActionResult copyroomserviceInfo(tb_copyroomservice model)
		{
			ViewBag.Info = dcopyroomservice.GetInfo(model);
			return View();
		}

	}
}

