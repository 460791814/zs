using System;
namespace 
{
	/// <summary>
	/// ������� ����Ԥ������
	/// </summary>
	public  class _meetingorderController:Controller
	{
		D_tb_meetingorder dtb_meetingorder = new D_tb_meetingorder();
		/// <summary>
		/// ������� ����Ԥ������ �б�
		/// </summary>
		public ActionResult   _meetingorderList(tb_meetingorder model)		{
			int count = 0;
			ViewBag.list = dtb_meetingorder.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

