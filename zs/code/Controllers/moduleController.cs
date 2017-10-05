using System;
namespace 
{
	/// <summary>
	/// Ȩ��ģ��
	/// </summary>
	public  class moduleController:Controller
	{
		D_module dmodule = new D_module();
		/// <summary>
		/// Ȩ��ģ�� �б�
		/// </summary>
		public ActionResult moduleList(tb_module model)
		{
			int count = 0;
			ViewBag.list = dtb_module.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// Ȩ��ģ�� ����
		/// </summary>
		public bool moduleSave(tb_module model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dmodule.Update(model);
			}
			return dmodule.Add(model)>0;
		}

		/// <summary>
		/// Ȩ��ģ�� ɾ��
		/// </summary>
		public bool moduleDelete(tb_module model)
		{
			return dmodule.Delete(model);
		}

		/// <summary>
		/// Ȩ��ģ�� ����
		/// </summary>
		public ActionResult moduleInfo(tb_module model)
		{
			ViewBag.Info = dmodule.GetInfo(model);
			return View();
		}

	}
}

