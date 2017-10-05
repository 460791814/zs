using System;
namespace 
{
	/// <summary>
	/// �ҵ��ղ�
	/// </summary>
	public  class favoriteController:Controller
	{
		D_favorite dfavorite = new D_favorite();
		/// <summary>
		/// �ҵ��ղ� �б�
		/// </summary>
		public ActionResult favoriteList(tb_favorite model)
		{
			int count = 0;
			ViewBag.list = dtb_favorite.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// �ҵ��ղ� ����
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
		/// �ҵ��ղ� ɾ��
		/// </summary>
		public bool favoriteDelete(tb_favorite model)
		{
			return dfavorite.Delete(model);
		}

		/// <summary>
		/// �ҵ��ղ� ����
		/// </summary>
		public ActionResult favoriteInfo(tb_favorite model)
		{
			ViewBag.Info = dfavorite.GetInfo(model);
			return View();
		}

	}
}

