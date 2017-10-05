using System;
namespace 
{
	/// <summary>
	/// 我的收藏
	/// </summary>
	public  class _favoriteController:Controller
	{
		D_tb_favorite dtb_favorite = new D_tb_favorite();
		/// <summary>
		/// 我的收藏 列表
		/// </summary>
		public ActionResult   _favoriteList(tb_favorite model)		{
			int count = 0;
			ViewBag.list = dtb_favorite.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

