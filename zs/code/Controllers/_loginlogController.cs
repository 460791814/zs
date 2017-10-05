using System;
namespace 
{
	/// <summary>
	/// 登陆日志
	/// </summary>
	public  class _loginlogController:Controller
	{
		D_tb_loginlog dtb_loginlog = new D_tb_loginlog();
		/// <summary>
		/// 登陆日志 列表
		/// </summary>
		public ActionResult   _loginlogList(tb_loginlog model)		{
			int count = 0;
			ViewBag.list = dtb_loginlog.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

