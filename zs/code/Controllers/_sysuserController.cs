using System;
namespace 
{
	/// <summary>
	/// 系统用户
	/// </summary>
	public  class _sysuserController:Controller
	{
		D_tb_sysuser dtb_sysuser = new D_tb_sysuser();
		/// <summary>
		/// 系统用户 列表
		/// </summary>
		public ActionResult   _sysuserList(tb_sysuser model)		{
			int count = 0;
			ViewBag.list = dtb_sysuser.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

