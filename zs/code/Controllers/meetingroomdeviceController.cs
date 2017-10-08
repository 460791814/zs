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
	/// �����������豸��ʩ
	/// </summary>
	public  class meetingroomdeviceController:Controller
	{
		D_meetingroomdevice dmeetingroomdevice = new D_meetingroomdevice();
		/// <summary>
		/// �����������豸��ʩ �б�
		/// </summary>
		public ActionResult meetingroomdeviceList(tb_meetingroomdevice model)
		{
			int count = 0;
			ViewBag.list = dmeetingroomdevice.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// �����������豸��ʩ ����
		/// </summary>
		public bool meetingroomdeviceSave(tb_meetingroomdevice model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return dmeetingroomdevice.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return dmeetingroomdevice.Add(model);
		}

		/// <summary>
		/// �����������豸��ʩ ɾ��
		/// </summary>
		public bool meetingroomdeviceDelete(tb_meetingroomdevice model)
		{
			return dmeetingroomdevice.Delete(model);
		}

		/// <summary>
		/// �����������豸��ʩ ����
		/// </summary>
		public ActionResult meetingroomdeviceInfo(tb_meetingroomdevice model)
		{
			model = dmeetingroomdevice.GetInfo(model);
			return View(model??new tb_meetingroomdevice());
		}

	}
}

