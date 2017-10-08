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
	/// �ײ�
	/// </summary>
	public  class comboController:Controller
	{
		D_combo dcombo = new D_combo();
		/// <summary>
		/// �ײ� �б�
		/// </summary>
		public ActionResult comboList(tb_combo model)
		{
			int count = 0;
			ViewBag.list = dcombo.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// �ײ� ����
		/// </summary>
		public bool comboSave(tb_combo model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return dcombo.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return dcombo.Add(model);
		}

		/// <summary>
		/// �ײ� ɾ��
		/// </summary>
		public bool comboDelete(tb_combo model)
		{
			return dcombo.Delete(model);
		}

		/// <summary>
		/// �ײ� ����
		/// </summary>
		public ActionResult comboInfo(tb_combo model)
		{
			model = dcombo.GetInfo(model);
			return View(model??new tb_combo());
		}

	}
}

