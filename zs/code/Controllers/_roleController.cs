using System;
namespace 
{
	/// <summary>
	/// ��ɫ
	/// </summary>
	public  class _roleController:Controller
	{
		D_tb_role dtb_role = new D_tb_role();
		/// <summary>
		/// ��ɫ �б�
		/// </summary>
		public ActionResult   _roleList(tb_role model)		{
			int count = 0;
			ViewBag.list = dtb_role.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

