using System;
namespace 
{
	/// <summary>
	/// ΢��
	/// </summary>
	public  class _weibolicenseController:Controller
	{
		D_tb_weibolicense dtb_weibolicense = new D_tb_weibolicense();
		/// <summary>
		/// ΢�� �б�
		/// </summary>
		public ActionResult   _weibolicenseList(tb_weibolicense model)		{
			int count = 0;
			ViewBag.list = dtb_weibolicense.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

