using System;
namespace 
{
	/// <summary>
	/// ��������
	/// </summary>
	public  class _statusController:Controller
	{
		D_tb_status dtb_status = new D_tb_status();
		/// <summary>
		/// �������� �б�
		/// </summary>
		public ActionResult   _statusList(tb_status model)		{
			int count = 0;
			ViewBag.list = dtb_status.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

