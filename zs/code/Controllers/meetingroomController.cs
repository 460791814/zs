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
	/// �����ҹ���
	/// </summary>
	public  class meetingroomController:Controller
	{
		D_meetingroom dmeetingroom = new D_meetingroom();
		/// <summary>
		/// �����ҹ��� �б�
		/// </summary>
		public ActionResult meetingroomList(tb_meetingroom model)
		{
			int count = 0;
			ViewBag.list = dmeetingroom.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// �����ҹ��� ����
		/// </summary>
		public bool meetingroomSave(tb_meetingroom model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return dmeetingroom.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return dmeetingroom.Add(model);
		}

		/// <summary>
		/// �����ҹ��� ɾ��
		/// </summary>
		public bool meetingroomDelete(tb_meetingroom model)
		{
			return dmeetingroom.Delete(model);
		}

		/// <summary>
		/// �����ҹ��� ����
		/// </summary>
		public ActionResult meetingroomInfo(tb_meetingroom model)
		{
			model = dmeetingroom.GetInfo(model);
			return View(model??new tb_meetingroom());
		}

	}
}

