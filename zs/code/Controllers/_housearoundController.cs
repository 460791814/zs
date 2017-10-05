using System;
namespace 
{
	/// <summary>
	/// ÖÜ±ßÅäÌ×½éÉÜ
	/// </summary>
	public  class _housearoundController:Controller
	{
		D_tb_housearound dtb_housearound = new D_tb_housearound();
		/// <summary>
		/// ÖÜ±ßÅäÌ×½éÉÜ ÁĞ±í
		/// </summary>
		public ActionResult   _housearoundList(tb_housearound model)		{
			int count = 0;
			ViewBag.list = dtb_housearound.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

