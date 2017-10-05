using System;
namespace 
{
	/// <summary>
	/// 家具
	/// </summary>
	public  class roomfurnitureController:Controller
	{
		D_roomfurniture droomfurniture = new D_roomfurniture();
		/// <summary>
		/// 家具 列表
		/// </summary>
		public ActionResult roomfurnitureList(tb_roomfurniture model)
		{
			int count = 0;
			ViewBag.list = dtb_roomfurniture.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// 家具 保存
		/// </summary>
		public bool roomfurnitureSave(tb_roomfurniture model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return droomfurniture.Update(model);
			}
			return droomfurniture.Add(model)>0;
		}

		/// <summary>
		/// 家具 删除
		/// </summary>
		public bool roomfurnitureDelete(tb_roomfurniture model)
		{
			return droomfurniture.Delete(model);
		}

		/// <summary>
		/// 家具 详情
		/// </summary>
		public ActionResult roomfurnitureInfo(tb_roomfurniture model)
		{
			ViewBag.Info = droomfurniture.GetInfo(model);
			return View();
		}

	}
}

