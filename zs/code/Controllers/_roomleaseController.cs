using System;
namespace 
{
	/// <summary>
	/// �������
	/// </summary>
	public  class _roomleaseController:Controller
	{
		D_tb_roomlease dtb_roomlease = new D_tb_roomlease();
		/// <summary>
		/// ������� �б�
		/// </summary>
		public ActionResult   _roomleaseList(tb_roomlease model)		{
			int count = 0;
			ViewBag.list = dtb_roomlease.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

