using System;
namespace 
{
	/// <summary>
	/// �����ҹ���
	/// </summary>
	public  class _meetingroomController:Controller
	{
		D_tb_meetingroom dtb_meetingroom = new D_tb_meetingroom();
		/// <summary>
		/// �����ҹ��� �б�
		/// </summary>
		public ActionResult   _meetingroomList(tb_meetingroom model)		{
			int count = 0;
			ViewBag.list = dtb_meetingroom.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

