using System;
namespace 
{
	/// <summary>
	/// �ܱ����׽���
	/// </summary>
	public  class _housearoundController:Controller
	{
		D_tb_housearound dtb_housearound = new D_tb_housearound();
		/// <summary>
		/// �ܱ����׽��� �б�
		/// </summary>
		public ActionResult   _housearoundList(tb_housearound model)		{
			int count = 0;
			ViewBag.list = dtb_housearound.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

