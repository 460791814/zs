using System;
namespace 
{
	/// <summary>
	/// �ֻ�������֤��
	/// </summary>
	public  class _smsController:Controller
	{
		D_tb_sms dtb_sms = new D_tb_sms();
		/// <summary>
		/// �ֻ�������֤�� �б�
		/// </summary>
		public ActionResult   _smsList(tb_sms model)		{
			int count = 0;
			ViewBag.list = dtb_sms.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

