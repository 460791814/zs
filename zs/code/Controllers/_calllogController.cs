using System;
namespace 
{
	/// <summary>
	/// ���м�¼
	/// </summary>
	public  class _calllogController:Controller
	{
		D_tb_calllog dtb_calllog = new D_tb_calllog();
		/// <summary>
		/// ���м�¼ �б�
		/// </summary>
		public ActionResult   _calllogList(tb_calllog model)		{
			int count = 0;
			ViewBag.list = dtb_calllog.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

