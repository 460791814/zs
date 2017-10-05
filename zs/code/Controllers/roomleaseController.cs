using System;
namespace 
{
	/// <summary>
	/// 租赁情况
	/// </summary>
	public  class roomleaseController:Controller
	{
		D_roomlease droomlease = new D_roomlease();
		/// <summary>
		/// 租赁情况 列表
		/// </summary>
		public ActionResult roomleaseList(tb_roomlease model)
		{
			int count = 0;
			ViewBag.list = dtb_roomlease.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// 租赁情况 保存
		/// </summary>
		public bool roomleaseSave(tb_roomlease model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return droomlease.Update(model);
			}
			return droomlease.Add(model)>0;
		}

		/// <summary>
		/// 租赁情况 删除
		/// </summary>
		public bool roomleaseDelete(tb_roomlease model)
		{
			return droomlease.Delete(model);
		}

		/// <summary>
		/// 租赁情况 详情
		/// </summary>
		public ActionResult roomleaseInfo(tb_roomlease model)
		{
			ViewBag.Info = droomlease.GetInfo(model);
			return View();
		}

	}
}

