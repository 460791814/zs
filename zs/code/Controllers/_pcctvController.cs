using System;
namespace 
{
	/// <summary>
	/// ʡ������
	/// </summary>
	public  class _pcctvController:Controller
	{
		D_tb_pcctv dtb_pcctv = new D_tb_pcctv();
		/// <summary>
		/// ʡ������ �б�
		/// </summary>
		public ActionResult   _pcctvList(tb_pcctv model)		{
			int count = 0;
			ViewBag.list = dtb_pcctv.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

