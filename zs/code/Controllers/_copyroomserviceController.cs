using System;
namespace 
{
	/// <summary>
	/// �������
	/// </summary>
	public  class _copyroomserviceController:Controller
	{
		D_tb_copyroomservice dtb_copyroomservice = new D_tb_copyroomservice();
		/// <summary>
		/// ������� �б�
		/// </summary>
		public ActionResult   _copyroomserviceList(tb_copyroomservice model)		{
			int count = 0;
			ViewBag.list = dtb_copyroomservice.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

