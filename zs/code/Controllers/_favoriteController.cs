using System;
namespace 
{
	/// <summary>
	/// �ҵ��ղ�
	/// </summary>
	public  class _favoriteController:Controller
	{
		D_tb_favorite dtb_favorite = new D_tb_favorite();
		/// <summary>
		/// �ҵ��ղ� �б�
		/// </summary>
		public ActionResult   _favoriteList(tb_favorite model)		{
			int count = 0;
			ViewBag.list = dtb_favorite.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

