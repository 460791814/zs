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
	/// �������
	/// </summary>
	public  class roomleaseController:Controller
	{
		D_roomlease droomlease = new D_roomlease();
		/// <summary>
		/// ������� �б�
		/// </summary>
		public ActionResult roomleaseList(tb_roomlease model)
		{
			int count = 0;
			ViewBag.list = droomlease.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ������� ����
		/// </summary>
		public bool roomleaseSave(tb_roomlease model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return droomlease.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return droomlease.Add(model);
		}

		/// <summary>
		/// ������� ɾ��
		/// </summary>
		public bool roomleaseDelete(tb_roomlease model)
		{
			return droomlease.Delete(model);
		}

		/// <summary>
		/// ������� ����
		/// </summary>
		public ActionResult roomleaseInfo(tb_roomlease model)
		{
			model = droomlease.GetInfo(model);
			return View(model??new tb_roomlease());
		}

	}
}

