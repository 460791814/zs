using System;
namespace 
{
	/// <summary>
	/// ¥�����׷���
	/// </summary>
	public  class _houseserviceController:Controller
	{
		D_tb_houseservice dtb_houseservice = new D_tb_houseservice();
		/// <summary>
		/// ¥�����׷��� �б�
		/// </summary>
		public ActionResult   _houseserviceList(tb_houseservice model)		{
			int count = 0;
			ViewBag.list = dtb_houseservice.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

