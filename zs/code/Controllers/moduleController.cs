using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using Model;
using Comp;
namespace cnooc.property.manage.Controllers
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
			ViewBag.list = dmodule.GetList(model, ref count);
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
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return dmodule.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return dmodule.Add(model);
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
			model = dmodule.GetInfo(model);
			return View(model??new tb_module());
		}

	}
}

