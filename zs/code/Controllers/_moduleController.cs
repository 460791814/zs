using System;
namespace 
{
	/// <summary>
	/// Ȩ��ģ��
	/// </summary>
	public  class _moduleController:Controller
	{
		D_tb_module dtb_module = new D_tb_module();
		/// <summary>
		/// Ȩ��ģ�� �б�
		/// </summary>
		public ActionResult   _moduleList(tb_module model)		{
			int count = 0;
			ViewBag.list = dtb_module.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

