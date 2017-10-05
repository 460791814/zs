using System;
namespace 
{
	/// <summary>
	/// 楼层展示图
	/// </summary>
	public  class _roomfaceController:Controller
	{
		D_tb_roomface dtb_roomface = new D_tb_roomface();
		/// <summary>
		/// 楼层展示图 列表
		/// </summary>
		public ActionResult   _roomfaceList(tb_roomface model)		{
			int count = 0;
			ViewBag.list = dtb_roomface.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

