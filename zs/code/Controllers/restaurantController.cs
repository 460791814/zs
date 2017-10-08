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
	/// ������ʳ
	/// </summary>
	public  class restaurantController:Controller
	{
		D_restaurant drestaurant = new D_restaurant();
		/// <summary>
		/// ������ʳ �б�
		/// </summary>
		public ActionResult restaurantList(tb_restaurant model)
		{
			int count = 0;
			ViewBag.list = drestaurant.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ������ʳ ����
		/// </summary>
		public bool restaurantSave(tb_restaurant model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return drestaurant.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return drestaurant.Add(model);
		}

		/// <summary>
		/// ������ʳ ɾ��
		/// </summary>
		public bool restaurantDelete(tb_restaurant model)
		{
			return drestaurant.Delete(model);
		}

		/// <summary>
		/// ������ʳ ����
		/// </summary>
		public ActionResult restaurantInfo(tb_restaurant model)
		{
			model = drestaurant.GetInfo(model);
			return View(model??new tb_restaurant());
		}

	}
}

