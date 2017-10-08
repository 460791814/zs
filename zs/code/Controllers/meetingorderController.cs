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
	/// ������� ����Ԥ������
	/// </summary>
	public  class meetingorderController:Controller
	{
		D_meetingorder dmeetingorder = new D_meetingorder();
		/// <summary>
		/// ������� ����Ԥ������ �б�
		/// </summary>
		public ActionResult meetingorderList(tb_meetingorder model)
		{
			int count = 0;
			ViewBag.list = dmeetingorder.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ������� ����Ԥ������ ����
		/// </summary>
		public bool meetingorderSave(tb_meetingorder model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return dmeetingorder.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return dmeetingorder.Add(model);
		}

		/// <summary>
		/// ������� ����Ԥ������ ɾ��
		/// </summary>
		public bool meetingorderDelete(tb_meetingorder model)
		{
			return dmeetingorder.Delete(model);
		}

		/// <summary>
		/// ������� ����Ԥ������ ����
		/// </summary>
		public ActionResult meetingorderInfo(tb_meetingorder model)
		{
			model = dmeetingorder.GetInfo(model);
			return View(model??new tb_meetingorder());
		}

	}
}

