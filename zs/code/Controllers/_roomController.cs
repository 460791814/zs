using System;
namespace 
{
	/// <summary>
	/// 房屋租赁
	/// </summary>
	public  class _roomController:Controller
	{
		D_tb_room dtb_room = new D_tb_room();
		/// <summary>
		/// 房屋租赁 列表
		/// </summary>
		public ActionResult   _roomList(tb_room model)		{
			int count = 0;
			ViewBag.list = dtb_room.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

