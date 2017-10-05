using System;
namespace 
{
	/// <summary>
	/// 家具
	/// </summary>
	public  class _roomfurnitureController:Controller
	{
		D_tb_roomfurniture dtb_roomfurniture = new D_tb_roomfurniture();
		/// <summary>
		/// 家具 列表
		/// </summary>
		public ActionResult   _roomfurnitureList(tb_roomfurniture model)		{
			int count = 0;
			ViewBag.list = dtb_roomfurniture.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

