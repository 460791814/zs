using System;
namespace 
{
	/// <summary>
	/// ʡ
	/// </summary>
	public  class _provinceController:Controller
	{
		D_tb_province dtb_province = new D_tb_province();
		/// <summary>
		/// ʡ �б�
		/// </summary>
		public ActionResult   _provinceList(tb_province model)		{
			int count = 0;
			ViewBag.list = dtb_province.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

