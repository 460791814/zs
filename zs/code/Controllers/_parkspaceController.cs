using System;
namespace 
{
	/// <summary>
	/// ���೵�ͳ�λ����
	/// </summary>
	public  class _parkspaceController:Controller
	{
		D_tb_parkspace dtb_parkspace = new D_tb_parkspace();
		/// <summary>
		/// ���೵�ͳ�λ���� �б�
		/// </summary>
		public ActionResult   _parkspaceList(tb_parkspace model)		{
			int count = 0;
			ViewBag.list = dtb_parkspace.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

