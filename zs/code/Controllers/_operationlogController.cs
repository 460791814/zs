using System;
namespace 
{
	/// <summary>
	/// ������־
	/// </summary>
	public  class _operationlogController:Controller
	{
		D_tb_operationlog dtb_operationlog = new D_tb_operationlog();
		/// <summary>
		/// ������־ �б�
		/// </summary>
		public ActionResult   _operationlogList(tb_operationlog model)		{
			int count = 0;
			ViewBag.list = dtb_operationlog.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

