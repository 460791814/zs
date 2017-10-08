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
	/// ��������
	/// </summary>
	public  class statusController:Controller
	{
		D_status dstatus = new D_status();
		/// <summary>
		/// �������� �б�
		/// </summary>
		public ActionResult statusList(tb_status model)
		{
			int count = 0;
			ViewBag.list = dstatus.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// �������� ����
		/// </summary>
		public bool statusSave(tb_status model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return dstatus.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return dstatus.Add(model);
		}

		/// <summary>
		/// �������� ɾ��
		/// </summary>
		public bool statusDelete(tb_status model)
		{
			return dstatus.Delete(model);
		}

		/// <summary>
		/// �������� ����
		/// </summary>
		public ActionResult statusInfo(tb_status model)
		{
			model = dstatus.GetInfo(model);
			return View(model??new tb_status());
		}

	}
}

