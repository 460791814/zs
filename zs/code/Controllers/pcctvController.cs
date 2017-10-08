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
	/// ʡ������
	/// </summary>
	public  class pcctvController:Controller
	{
		D_pcctv dpcctv = new D_pcctv();
		/// <summary>
		/// ʡ������ �б�
		/// </summary>
		public ActionResult pcctvList(tb_pcctv model)
		{
			int count = 0;
			ViewBag.list = dpcctv.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ʡ������ ����
		/// </summary>
		public bool pcctvSave(tb_pcctv model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return dpcctv.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return dpcctv.Add(model);
		}

		/// <summary>
		/// ʡ������ ɾ��
		/// </summary>
		public bool pcctvDelete(tb_pcctv model)
		{
			return dpcctv.Delete(model);
		}

		/// <summary>
		/// ʡ������ ����
		/// </summary>
		public ActionResult pcctvInfo(tb_pcctv model)
		{
			model = dpcctv.GetInfo(model);
			return View(model??new tb_pcctv());
		}

	}
}

