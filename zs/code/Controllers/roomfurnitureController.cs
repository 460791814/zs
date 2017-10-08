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
	/// �Ҿ�
	/// </summary>
	public  class roomfurnitureController:Controller
	{
		D_roomfurniture droomfurniture = new D_roomfurniture();
		/// <summary>
		/// �Ҿ� �б�
		/// </summary>
		public ActionResult roomfurnitureList(tb_roomfurniture model)
		{
			int count = 0;
			ViewBag.list = droomfurniture.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// �Ҿ� ����
		/// </summary>
		public bool roomfurnitureSave(tb_roomfurniture model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return droomfurniture.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return droomfurniture.Add(model);
		}

		/// <summary>
		/// �Ҿ� ɾ��
		/// </summary>
		public bool roomfurnitureDelete(tb_roomfurniture model)
		{
			return droomfurniture.Delete(model);
		}

		/// <summary>
		/// �Ҿ� ����
		/// </summary>
		public ActionResult roomfurnitureInfo(tb_roomfurniture model)
		{
			model = droomfurniture.GetInfo(model);
			return View(model??new tb_roomfurniture());
		}

	}
}

