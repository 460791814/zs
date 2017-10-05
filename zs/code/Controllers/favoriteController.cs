using System;
namespace 
{
	/// <summary>
	/// 我的收藏
	/// </summary>
	public  class favoriteController:Controller
	{
		D_favorite dfavorite = new D_favorite();
		/// <summary>
		/// 我的收藏 列表
		/// </summary>
		public ActionResult favoriteList(tb_favorite model)
		{
			int count = 0;
			ViewBag.list = dtb_favorite.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// 我的收藏 保存
		/// </summary>
		public bool favoriteSave(tb_favorite model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dfavorite.Update(model);
			}
			return dfavorite.Add(model)>0;
		}

		/// <summary>
		/// 我的收藏 删除
		/// </summary>
		public bool favoriteDelete(tb_favorite model)
		{
			return dfavorite.Delete(model);
		}

		/// <summary>
		/// 我的收藏 详情
		/// </summary>
		public ActionResult favoriteInfo(tb_favorite model)
		{
			ViewBag.Info = dfavorite.GetInfo(model);
			return View();
		}

	}
}

