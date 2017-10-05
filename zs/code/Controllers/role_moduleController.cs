using System;
namespace 
{
	/// <summary>
	/// Ȩ��ģ���ϵ��
	/// </summary>
	public  class role_moduleController:Controller
	{
		D_role_module drole_module = new D_role_module();
		/// <summary>
		/// Ȩ��ģ���ϵ�� �б�
		/// </summary>
		public ActionResult role_moduleList(tb_role_module model)
		{
			int count = 0;
			ViewBag.list = dtb_role_module.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// Ȩ��ģ���ϵ�� ����
		/// </summary>
		public bool role_moduleSave(tb_role_module model)
		{
			if (model == null)
			{
				return false
			}
			if (model.roleid >0)
			{
				 return drole_module.Update(model);
			}
			return drole_module.Add(model)>0;
		}

		/// <summary>
		/// Ȩ��ģ���ϵ�� ɾ��
		/// </summary>
		public bool role_moduleDelete(tb_role_module model)
		{
			return drole_module.Delete(model);
		}

		/// <summary>
		/// Ȩ��ģ���ϵ�� ����
		/// </summary>
		public ActionResult role_moduleInfo(tb_role_module model)
		{
			ViewBag.Info = drole_module.GetInfo(model);
			return View();
		}

	}
}

