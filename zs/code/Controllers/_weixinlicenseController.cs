using System;
namespace 
{
	/// <summary>
	/// ΢��
	/// </summary>
	public  class _weixinlicenseController:Controller
	{
		D_tb_weixinlicense dtb_weixinlicense = new D_tb_weixinlicense();
		/// <summary>
		/// ΢�� �б�
		/// </summary>
		public ActionResult   _weixinlicenseList(tb_weixinlicense model)		{
			int count = 0;
			ViewBag.list = dtb_weixinlicense.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

