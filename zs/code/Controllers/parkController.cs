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
	/// ��λ��Ϣ
	/// </summary>
	public  class parkController:Controller
	{
		D_park dpark = new D_park();
		/// <summary>
		/// ��λ��Ϣ �б�
		/// </summary>
		public ActionResult parkList(tb_park model)
		{
			int count = 0;
			ViewBag.list = dpark.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ��λ��Ϣ ����
		/// </summary>
		public bool parkSave(tb_park model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return dpark.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return dpark.Add(model);
		}

		/// <summary>
		/// ��λ��Ϣ ɾ��
		/// </summary>
		public bool parkDelete(tb_park model)
		{
			return dpark.Delete(model);
		}

		/// <summary>
		/// ��λ��Ϣ ����
		/// </summary>
		public ActionResult parkInfo(tb_park model)
		{
			model = dpark.GetInfo(model);
			return View(model??new tb_park());
		}

	}
}

