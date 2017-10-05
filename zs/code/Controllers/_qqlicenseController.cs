using System;
namespace 
{
	/// <summary>
	/// qq
	/// </summary>
	public  class _qqlicenseController:Controller
	{
		D_tb_qqlicense dtb_qqlicense = new D_tb_qqlicense();
		/// <summary>
		/// qq ап╠М
		/// </summary>
		public ActionResult   _qqlicenseList(tb_qqlicense model)		{
			int count = 0;
			ViewBag.list = dtb_qqlicense.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

