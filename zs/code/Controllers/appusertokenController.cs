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
	/// App�û���½Token
	/// </summary>
	public  class appusertokenController:Controller
	{
		D_appusertoken dappusertoken = new D_appusertoken();
		/// <summary>
		/// App�û���½Token �б�
		/// </summary>
		public ActionResult appusertokenList(tb_appusertoken model)
		{
			int count = 0;
			ViewBag.list = dappusertoken.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// App�û���½Token ����
		/// </summary>
		public bool appusertokenSave(tb_appusertoken model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return dappusertoken.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return dappusertoken.Add(model);
		}

		/// <summary>
		/// App�û���½Token ɾ��
		/// </summary>
		public bool appusertokenDelete(tb_appusertoken model)
		{
			return dappusertoken.Delete(model);
		}

		/// <summary>
		/// App�û���½Token ����
		/// </summary>
		public ActionResult appusertokenInfo(tb_appusertoken model)
		{
			model = dappusertoken.GetInfo(model);
			return View(model??new tb_appusertoken());
		}

	}
}

