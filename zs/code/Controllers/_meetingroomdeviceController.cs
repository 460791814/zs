using System;
namespace 
{
	/// <summary>
	/// �����������豸��ʩ
	/// </summary>
	public  class _meetingroomdeviceController:Controller
	{
		D_tb_meetingroomdevice dtb_meetingroomdevice = new D_tb_meetingroomdevice();
		/// <summary>
		/// �����������豸��ʩ �б�
		/// </summary>
		public ActionResult   _meetingroomdeviceList(tb_meetingroomdevice model)		{
			int count = 0;
			ViewBag.list = dtb_meetingroomdevice.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

