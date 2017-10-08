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
	/// ¥�������豸
	/// </summary>
	public  class buildingdeviceController:Controller
	{
		D_buildingdevice dbuildingdevice = new D_buildingdevice();
		/// <summary>
		/// ¥�������豸 �б�
		/// </summary>
		public ActionResult buildingdeviceList(tb_buildingdevice model)
		{
			int count = 0;
			ViewBag.list = dbuildingdevice.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ¥�������豸 ����
		/// </summary>
		public bool buildingdeviceSave(tb_buildingdevice model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return dbuildingdevice.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return dbuildingdevice.Add(model);
		}

		/// <summary>
		/// ¥�������豸 ɾ��
		/// </summary>
		public bool buildingdeviceDelete(tb_buildingdevice model)
		{
			return dbuildingdevice.Delete(model);
		}

		/// <summary>
		/// ¥�������豸 ����
		/// </summary>
		public ActionResult buildingdeviceInfo(tb_buildingdevice model)
		{
			model = dbuildingdevice.GetInfo(model);
			return View(model??new tb_buildingdevice());
		}

	}
}

