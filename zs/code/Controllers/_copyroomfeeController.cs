using System;
namespace 
{
	/// <summary>
	/// 收费标准
	/// </summary>
	public  class _copyroomfeeController:Controller
	{
		D_tb_copyroomfee dtb_copyroomfee = new D_tb_copyroomfee();
		/// <summary>
		/// 收费标准 列表
		/// </summary>
		public ActionResult   _copyroomfeeList(tb_copyroomfee model)		{
			int count = 0;
			ViewBag.list = dtb_copyroomfee.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

