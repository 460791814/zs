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
	public  class roomController:Controller
	{
		D_room droom = new D_room();
		/// <summary>
		/// �������� �б�
		/// </summary>
		public ActionResult roomList(tb_room model)
		{
			int count = 0;
			ViewBag.list = droom.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// �������� ����
		/// </summary>
		public bool roomSave(tb_room model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return droom.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return droom.Add(model);
		}

		/// <summary>
		/// �������� ɾ��
		/// </summary>
		public bool roomDelete(tb_room model)
		{
			return droom.Delete(model);
		}

		/// <summary>
		/// �������� ����
		/// </summary>
		public ActionResult roomInfo(tb_room model)
		{
			model = droom.GetInfo(model);
			return View(model??new tb_room());
		}

	}
}

