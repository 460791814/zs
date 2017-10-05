using System;
namespace 
{
	/// <summary>
	/// 網請暮翹
	/// </summary>
	public  class calllogController:Controller
	{
		D_calllog dcalllog = new D_calllog();
		/// <summary>
		/// 網請暮翹 蹈桶
		/// </summary>
		public ActionResult calllogList(tb_calllog model)
		{
			int count = 0;
			ViewBag.list = dtb_calllog.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// 網請暮翹 悵湔
		/// </summary>
		public bool calllogSave(tb_calllog model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dcalllog.Update(model);
			}
			return dcalllog.Add(model)>0;
		}

		/// <summary>
		/// 網請暮翹 刉壺
		/// </summary>
		public bool calllogDelete(tb_calllog model)
		{
			return dcalllog.Delete(model);
		}

		/// <summary>
		/// 網請暮翹 砆①
		/// </summary>
		public ActionResult calllogInfo(tb_calllog model)
		{
			ViewBag.Info = dcalllog.GetInfo(model);
			return View();
		}

	}
}

