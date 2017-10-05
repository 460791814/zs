using System;
namespace 
{
	/// <summary>
	/// 網請暮翹
	/// </summary>
	public  class _calllogController:Controller
	{
		D_tb_calllog dtb_calllog = new D_tb_calllog();
		/// <summary>
		/// 網請暮翹 蹈桶
		/// </summary>
		public ActionResult   _calllogList(tb_calllog model)		{
			int count = 0;
			ViewBag.list = dtb_calllog.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

