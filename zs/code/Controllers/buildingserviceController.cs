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
	/// ¥�����׷���
	/// </summary>
	public  class buildingserviceController:Controller
	{
		D_buildingservice dbuildingservice = new D_buildingservice();
		/// <summary>
		/// ¥�����׷��� �б�
		/// </summary>
		public ActionResult buildingserviceList(tb_buildingservice model)
		{
			int count = 0;
			ViewBag.list = dbuildingservice.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ¥�����׷��� ����
		/// </summary>
		public bool buildingserviceSave(tb_buildingservice model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return dbuildingservice.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return dbuildingservice.Add(model);
		}

		/// <summary>
		/// ¥�����׷��� ɾ��
		/// </summary>
		public bool buildingserviceDelete(tb_buildingservice model)
		{
			return dbuildingservice.Delete(model);
		}

		/// <summary>
		/// ¥�����׷��� ����
		/// </summary>
		public ActionResult buildingserviceInfo(tb_buildingservice model)
		{
			model = dbuildingservice.GetInfo(model);
			return View(model??new tb_buildingservice());
		}

	}
}

