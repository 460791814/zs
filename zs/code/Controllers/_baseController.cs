using System;
namespace 
{
	/// <summary>
	/// ��������
	/// </summary>
	public  class _baseController:Controller
	{
		D_tb_base dtb_base = new D_tb_base();
		/// <summary>
		/// �������� �б�
		/// </summary>
		public ActionResult   _baseList(tb_base model)		{
			int count = 0;
			ViewBag.list = dtb_base.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

