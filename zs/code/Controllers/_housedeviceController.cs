using System;
namespace 
{
	/// <summary>
	/// ¥�������豸
	/// </summary>
	public  class _housedeviceController:Controller
	{
		D_tb_housedevice dtb_housedevice = new D_tb_housedevice();
		/// <summary>
		/// ¥�������豸 �б�
		/// </summary>
		public ActionResult   _housedeviceList(tb_housedevice model)		{
			int count = 0;
			ViewBag.list = dtb_housedevice.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

