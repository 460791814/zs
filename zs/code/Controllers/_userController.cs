using System;
namespace 
{
	/// <summary>
	/// 客户表
	/// </summary>
	public  class _userController:Controller
	{
		D_tb_user dtb_user = new D_tb_user();
		/// <summary>
		/// 客户表 列表
		/// </summary>
		public ActionResult   _userList(tb_user model)		{
			int count = 0;
			ViewBag.list = dtb_user.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

