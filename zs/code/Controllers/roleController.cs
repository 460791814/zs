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
	/// ��ɫ
	/// </summary>
	public  class roleController:Controller
	{
		D_role drole = new D_role();
		/// <summary>
		/// ��ɫ �б�
		/// </summary>
		public ActionResult roleList(tb_role model)
		{
			int count = 0;
			ViewBag.list = drole.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ��ɫ ����
		/// </summary>
		public bool roleSave(tb_role model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return drole.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return drole.Add(model);
		}

		/// <summary>
		/// ��ɫ ɾ��
		/// </summary>
		public bool roleDelete(tb_role model)
		{
			return drole.Delete(model);
		}

		/// <summary>
		/// ��ɫ ����
		/// </summary>
		public ActionResult roleInfo(tb_role model)
		{
			model = drole.GetInfo(model);
			return View(model??new tb_role());
		}

	}
}

