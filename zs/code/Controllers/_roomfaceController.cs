using System;
namespace 
{
	/// <summary>
	/// ¥��չʾͼ
	/// </summary>
	public  class _roomfaceController:Controller
	{
		D_tb_roomface dtb_roomface = new D_tb_roomface();
		/// <summary>
		/// ¥��չʾͼ �б�
		/// </summary>
		public ActionResult   _roomfaceList(tb_roomface model)		{
			int count = 0;
			ViewBag.list = dtb_roomface.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

