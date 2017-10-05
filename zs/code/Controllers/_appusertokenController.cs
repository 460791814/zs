using System;
namespace 
{
	/// <summary>
	/// App用户登陆Token
	/// </summary>
	public  class _appusertokenController:Controller
	{
		D_tb_appusertoken dtb_appusertoken = new D_tb_appusertoken();
		/// <summary>
		/// App用户登陆Token 列表
		/// </summary>
		public ActionResult   _appusertokenList(tb_appusertoken model)		{
			int count = 0;
			ViewBag.list = dtb_appusertoken.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

