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
	/// ��ӡ���
	/// </summary>
	public  class copyroomController:Controller
	{
		D_copyroom dcopyroom = new D_copyroom();
		/// <summary>
		/// ��ӡ��� �б�
		/// </summary>
		public ActionResult copyroomList(tb_copyroom model)
		{
			int count = 0;
			ViewBag.list = dcopyroom.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ��ӡ��� ����
		/// </summary>
		public bool copyroomSave(tb_copyroom model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return dcopyroom.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return dcopyroom.Add(model);
		}

		/// <summary>
		/// ��ӡ��� ɾ��
		/// </summary>
		public bool copyroomDelete(tb_copyroom model)
		{
			return dcopyroom.Delete(model);
		}

		/// <summary>
		/// ��ӡ��� ����
		/// </summary>
		public ActionResult copyroomInfo(tb_copyroom model)
		{
			model = dcopyroom.GetInfo(model);
			return View(model??new tb_copyroom());
		}

	}
}

