using System;
namespace 
{
	/// <summary>
	/// �ײ�
	/// </summary>
	public  class _comboController:Controller
	{
		D_tb_combo dtb_combo = new D_tb_combo();
		/// <summary>
		/// �ײ� �б�
		/// </summary>
		public ActionResult   _comboList(tb_combo model)		{
			int count = 0;
			ViewBag.list = dtb_combo.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

