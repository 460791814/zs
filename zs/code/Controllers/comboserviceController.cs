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
	/// �ײͷ�������
	/// </summary>
	public  class comboserviceController:Controller
	{
		D_comboservice dcomboservice = new D_comboservice();
		/// <summary>
		/// �ײͷ������� �б�
		/// </summary>
		public ActionResult comboserviceList(tb_comboservice model)
		{
			int count = 0;
			ViewBag.list = dcomboservice.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// �ײͷ������� ����
		/// </summary>
		public bool comboserviceSave(tb_comboservice model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return dcomboservice.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return dcomboservice.Add(model);
		}

		/// <summary>
		/// �ײͷ������� ɾ��
		/// </summary>
		public bool comboserviceDelete(tb_comboservice model)
		{
			return dcomboservice.Delete(model);
		}

		/// <summary>
		/// �ײͷ������� ����
		/// </summary>
		public ActionResult comboserviceInfo(tb_comboservice model)
		{
			model = dcomboservice.GetInfo(model);
			return View(model??new tb_comboservice());
		}

	}
}

