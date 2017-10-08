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
	/// ��
	/// </summary>
	public  class cityController:Controller
	{
		D_city dcity = new D_city();
		/// <summary>
		/// �� �б�
		/// </summary>
		public ActionResult cityList(tb_city model)
		{
			int count = 0;
			ViewBag.list = dcity.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// �� ����
		/// </summary>
		public bool citySave(tb_city model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return dcity.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return dcity.Add(model);
		}

		/// <summary>
		/// �� ɾ��
		/// </summary>
		public bool cityDelete(tb_city model)
		{
			return dcity.Delete(model);
		}

		/// <summary>
		/// �� ����
		/// </summary>
		public ActionResult cityInfo(tb_city model)
		{
			model = dcity.GetInfo(model);
			return View(model??new tb_city());
		}

	}
}

