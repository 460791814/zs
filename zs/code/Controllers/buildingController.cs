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
	/// ¥��
	/// </summary>
	public  class buildingController:Controller
	{
		D_building dbuilding = new D_building();
		/// <summary>
		/// ¥�� �б�
		/// </summary>
		public ActionResult buildingList(tb_building model)
		{
			int count = 0;
			ViewBag.list = dbuilding.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ¥�� ����
		/// </summary>
		public bool buildingSave(tb_building model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return dbuilding.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return dbuilding.Add(model);
		}

		/// <summary>
		/// ¥�� ɾ��
		/// </summary>
		public bool buildingDelete(tb_building model)
		{
			return dbuilding.Delete(model);
		}

		/// <summary>
		/// ¥�� ����
		/// </summary>
		public ActionResult buildingInfo(tb_building model)
		{
			model = dbuilding.GetInfo(model);
			return View(model??new tb_building());
		}

	}
}

