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
	/// ¥��չʾͼ
	/// </summary>
	public  class roomfaceController:Controller
	{
		D_roomface droomface = new D_roomface();
		/// <summary>
		/// ¥��չʾͼ �б�
		/// </summary>
		public ActionResult roomfaceList(tb_roomface model)
		{
			int count = 0;
			ViewBag.list = droomface.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ¥��չʾͼ ����
		/// </summary>
		public bool roomfaceSave(tb_roomface model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return droomface.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return droomface.Add(model);
		}

		/// <summary>
		/// ¥��չʾͼ ɾ��
		/// </summary>
		public bool roomfaceDelete(tb_roomface model)
		{
			return droomface.Delete(model);
		}

		/// <summary>
		/// ¥��չʾͼ ����
		/// </summary>
		public ActionResult roomfaceInfo(tb_roomface model)
		{
			model = droomface.GetInfo(model);
			return View(model??new tb_roomface());
		}

	}
}

