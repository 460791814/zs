using System;
namespace 
{
	/// <summary>
	/// 省市区县
	/// </summary>
	public  class pcctvController:Controller
	{
		D_pcctv dpcctv = new D_pcctv();
		/// <summary>
		/// 省市区县 列表
		/// </summary>
		public ActionResult pcctvList(tb_pcctv model)
		{
			int count = 0;
			ViewBag.list = dtb_pcctv.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// 省市区县 保存
		/// </summary>
		public bool pcctvSave(tb_pcctv model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dpcctv.Update(model);
			}
			return dpcctv.Add(model)>0;
		}

		/// <summary>
		/// 省市区县 删除
		/// </summary>
		public bool pcctvDelete(tb_pcctv model)
		{
			return dpcctv.Delete(model);
		}

		/// <summary>
		/// 省市区县 详情
		/// </summary>
		public ActionResult pcctvInfo(tb_pcctv model)
		{
			ViewBag.Info = dpcctv.GetInfo(model);
			return View();
		}

	}
}

