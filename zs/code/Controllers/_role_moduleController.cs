using System;
namespace 
{
	/// <summary>
	/// Ȩ��ģ���ϵ��
	/// </summary>
	public  class _role_moduleController:Controller
	{
		D_tb_role_module dtb_role_module = new D_tb_role_module();
		/// <summary>
		/// Ȩ��ģ���ϵ�� �б�
		/// </summary>
		public ActionResult   _role_moduleList(tb_role_module model)		{
			int count = 0;
			ViewBag.list = dtb_role_module.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

